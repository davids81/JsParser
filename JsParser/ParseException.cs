using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsParser
{
	public class ParseException : Exception
	{
		public ParseException() : base()
		{

		}

		public ParseException(string Message) : base(Message)
		{

		}
	}
}
