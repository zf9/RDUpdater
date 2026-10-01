# Uniden R Series Tools (Modified)

An unofficial, community-modified build of the **Uniden R Series Tools** (v2.23) desktop app for the **R4NZ** and **R8NZ** radar detectors, adding the **M.Cam** setting and an in-app **Updates** tab.

> ⚠️ **Unofficial project.** Not affiliated with, endorsed by, or supported by Uniden. Use at your own risk. See [Disclaimer](#disclaimer).

> ❗ **Tested on the R4NZ running firmware v135 only.** Other models (including the R8NZ) and firmware versions have not been tested, so behavior may differ. Back up your settings before making changes.

---

## What's New

### 1. M.Cam (Option 42) in Band Settings
Adds the **M.Cam** option to **User Setting → Band Setting** as item **42**.

- Activates Mobile Camera (Acusensus) detection
- Values: `On` / `Off`
- Loads from and stores to the unit like any other band setting

![M.Cam setting](https://github.com/zf9/RDUpdater/blob/main/Images/UserSettings.png?raw=true)

### 2. Updates Tab
A new **Updates** tab that lets you fetch the latest firmware and GPS database files for your connected detector.

**How it works:**

1. Press **Fetch**
2. The app detects which detector is connected (R4NZ or R8NZ)
3. It sends a request to a **Cloudflare Worker**
4. The Worker checks the Blulink website and returns the available downloads
5. The app lists **Firmware** and **GPS database** with their last-updated dates
6. Press **Download...** and choose where to save the file

> Files are saved only. **Nothing is installed automatically.** Flash/install them using the normal Update tab as usual.

| Before Fetch | After Fetch |
|---|---|
| ![Updates tab](https://github.com/zf9/RDUpdater/blob/main/Images/DeadUpdates.png?raw=true) | ![Fetch results](https://github.com/zf9/RDUpdater/blob/main/Images/UpdatesMenu.png?raw=true) |

---

## Architecture

```
┌──────────────────┐      ┌───────────────────┐      ┌──────────────────┐
│  R Series Tools  │ ───▶ │ Cloudflare Worker │ ───▶ │ Blulink website  │
│  (Updates tab)   │ ◀─── │  (scrape + JSON)  │ ◀─── │ (firmware / GPS) │
└──────────────────┘      └───────────────────┘      └──────────────────┘
   sends detector model     checks Blulink,            source of truth
   (R4NZ / R8NZ)            returns file info
```

Using a Worker as a middle layer means the app doesn't need to scrape or parse the Blulink site itself. If Blulink changes their page layout, only the Worker needs updating, not the desktop app.

---

## Supported Devices

| Model | Supported |
|-------|-----------|
| Uniden R4NZ | ✅ |
| Uniden R8NZ | ✅ |

---

## Installation

1. Download the latest build from the [Releases](../../releases) page
2. Copy the modified `.exe` into the original install folder:
   `C:\Program Files (x86)\Uniden America\Uniden R Series Tool`
3. Leave the original `.exe` untouched. It stays there as your backup, so you can always go back to the stock version
4. Right-click the modified `.exe` and choose **Send to → Desktop (create shortcut)**
5. Connect your detector via USB and launch the app from the new shortcut

---

## How This Was Made

- Original application decompiled and modified using **[dnSpy](https://github.com/dnSpy/dnSpy)**
- Help from my best friend **Claude Code**
- Worker built on **Cloudflare Workers**

---

🔍 [View the VirusTotal scan](https://www.virustotal.com/gui/file/08bb43dd6ebd8ead67c00453c8762ab241b1f05d2d9553ce95f157dbf657a529)

---

## Disclaimer

- This project is **unofficial** and is provided **as is**, with no warranty of any kind.
- Modifying device settings or flashing firmware can cause unexpected behavior. **You are responsible for your own device.** Back up your settings first using **Store to unit / Save file** before making changes.
- **Uniden** and **Blulink** are trademarks of their respective owners. This repository does not claim any ownership of Uniden's software, firmware, or GPS data.
- Firmware and GPS files are downloaded directly from Blulink via the Worker. They are **not hosted or redistributed** by this project.
- Please make sure your use complies with the laws in your region regarding radar detectors and with any applicable software license terms.

---

## Contributing

Issues and pull requests are welcome. If you find another hidden or useful option, open an issue and let's get it added.

## License

Original code in this repository is released under the [MIT License](LICENSE). This does **not** cover Uniden's original software or assets.
