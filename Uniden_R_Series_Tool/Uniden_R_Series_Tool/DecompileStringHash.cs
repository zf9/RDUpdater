namespace Uniden_R_Series_Tool
{
	internal static class DecompileStringHash
	{
		// DECOMPILE-FIX: Restore the omitted <PrivateImplementationDetails> string-switch
		// helper under a legal C# name. Constants, null handling, and unchecked UTF-16
		// arithmetic match ComputeStringHash in the original executable's IL.
		internal static uint ComputeStringHash(string value)
		{
			if (value == null)
			{
				return 0;
			}
			uint hash = 2166136261U;
			for (int i = 0; i < value.Length; i++)
			{
				hash = unchecked((value[i] ^ hash) * 16777619U);
			}
			return hash;
		}
	}
}
