using System.Text;

namespace LifeGame
{
	public sealed class MyParse
	{
		private string line;
		private char marker;

		public MyParse(string line)
		{
			this.line = line;
			marker = line[0];
		}

		public char Marker
		{
			get { return marker; }
		}

		public int Parse()
		{
			bool allDigits = true;
			int parameter = 0;
			StringBuilder number = new StringBuilder();
			for (int i = 1; i < line.Length; ++i)
			{
				if (line[i] < '0' || line[i] >= '9')
				{
					allDigits = false;
					break;
				}
				else
				{
					number.Append(line[i]);
				}
			}
			if (allDigits)
			{
				parameter = int.Parse(number.ToString());
			}
			return parameter;
		}
	}
}