using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsParser
{
    public enum TokenType
    {
        BeginObject,
        EndObject,
        BeginArray,
        EndArray,
        PairSeparator,
        Minus,
        Number,
        Object,
        Array,
        True,
        False,
        Null,
        DoubleQuote,
        BackSlash,
        ForewardSlash,
        Backspace,
        FormFeed,
        NewLine,
        CarriageReturn,
        HorizontalTab,
        Hex,
        String,
        PairDelim,
        Comma,
        EOF
    }
}
