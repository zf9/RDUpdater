export default {
  async fetch(request, env, ctx) {
    const url = new URL(request.url);
    const detector = url.searchParams.get("detector")?.toUpperCase();

    const products = {
      R4NZ: "https://blulink.co.nz/product/radar-detector-r4-nz/",
      R8NZ: "https://blulink.co.nz/product/radar-detector-r8-nz/",
    };

    const productUrl = products[detector];

    if (!productUrl) {
      return Response.json(
        {
          error: "Invalid or missing detector",
          available: Object.keys(products),
        },
        { status: 400 }
      );
    }

    const response = await fetch(productUrl);

    if (!response.ok) {
      return Response.json(
        { error: "Failed to fetch BluLink" },
        { status: 502 }
      );
    }

    const html = await response.text();

    // Extract individual <li> elements
    const listItems = html.match(/<li\b[^>]*>[\s\S]*?<\/li>/gi) || [];

    let firmware = null;
    let gps = null;

    for (const li of listItems) {
      // Get the text content of this <li>
      const text = li
        .replace(/<[^>]+>/g, " ")
        .replace(/&nbsp;/gi, " ")
        .replace(/\s+/g, " ")
        .trim();

      // Extract download URL
      const urlMatch = li.match(
        /<a[^>]+href=["']([^"']+)["']/i
      );

      // Extract Last Updated date
      const dateMatch = li.match(
        /Last Updated\s*([^<]+)/i
      );

      if (!urlMatch || !dateMatch) {
        continue;
      }

      const downloadUrl = urlMatch[1];
      const lastUpdated = dateMatch[1]
        .replace(/&nbsp;/gi, " ")
        .trim();

      // Firmware
      if (/Firmware/i.test(text) && !/GPS Database/i.test(text)) {
        firmware = {
          downloadUrl,
          lastUpdated,
        };
      }

      // GPS Database
      if (/GPS Database/i.test(text)) {
        gps = {
          downloadUrl,
          lastUpdated,
        };
      }
    }

    if (!firmware && !gps) {
      return Response.json(
        { error: "Firmware and GPS information not found" },
        { status: 404 }
      );
    }

    return Response.json({
      firmware,
      gps,
    });
  },
};
