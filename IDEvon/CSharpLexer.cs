using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class CSharpLexer
{
public const int StyleDefault = 0;
    public const int StyleKeyword = 1;
    public const int StyleIdentifier = 2;
    public const int StyleNumber = 3;
    public const int StyleString = 4;

    private const int STATE_UNKNOWN = 0;
    private const int STATE_IDENTIFIER = 1;
    private const int STATE_NUMBER = 2;
    private const int STATE_COMMENT = 3;
    private const int STATE_FLOAT = 4;
    private const int STATE_COMMENT2 = 5;
    private const int STATE_COMMENT3 = 6;
    private const int STATE_COMMENT4 = 7;

    private HashSet<string> keywords;

    public void Style(Scintilla scintilla, int startPos, int endPos)
    {
        // Back up to the line start
        var line = scintilla.LineFromPosition(startPos);
        startPos = scintilla.Lines[line].Position;

        var length = 0;
        var state = STATE_UNKNOWN;

        // Start styling
        scintilla.StartStyling(startPos);

        while (startPos < endPos)
        {
            var c = (char)scintilla.GetCharAt(startPos);


        REPROCESS:
            switch (state)
            {
                case STATE_UNKNOWN:
                    if (c == '/')
                    {
                        scintilla.SetStyling(1, StyleDefault);
                        state = STATE_COMMENT;
                       // goto REPROCESS;
                    }
                    else if (Char.IsDigit(c))
                    {
                        state = STATE_NUMBER;
                        //goto REPROCESS;
                    }
                    else if (Char.IsLetter(c))
                    {
                        state = STATE_IDENTIFIER;
                        //goto REPROCESS;
                    }
                    else
                    {
                        // Everything else
                        scintilla.SetStyling(1, StyleDefault);
                    }
                    break;

                case STATE_COMMENT://-----------------------------------------------------Estado comentarios--------------------------------
                    if (c == '/')
                    {
                        scintilla.SetStyling(1, StyleString);
                        state = STATE_COMMENT2;
                       // goto REPROCESS;     
                    }
                    else if (c == '*')
                    {
                        scintilla.SetStyling(1, StyleString);
                        state = STATE_COMMENT3;
                        goto REPROCESS;
                    }
                    else
                    {
                        //division
                        state = STATE_UNKNOWN;
                        // goto REPROCESS;
                        startPos--;
                    }

                    break;
                case STATE_COMMENT2:
                    if (c == '\n')
                    {
                        state = STATE_UNKNOWN;
                        //goto REPROCESS;
                    }
                    else
                    {
                        scintilla.SetStyling(1, StyleString);
                        state = STATE_COMMENT2;
                        //goto REPROCESS;
                    }
                    break;
                case STATE_COMMENT3:
                    if (c == '*')
                    {
                        scintilla.SetStyling(1, StyleString);
                        state = STATE_COMMENT4;
                        //goto REPROCESS;
                    }
                    else
                    {
                        scintilla.SetStyling(1, StyleString);
                        state = STATE_COMMENT3;
                       // goto REPROCESS;
                       
                    }
                    break;
                case STATE_COMMENT4:
                    if (c == '/')
                    {
                        scintilla.SetStyling(1, StyleString);
                        state = STATE_UNKNOWN;
                        goto REPROCESS;
                    }
                    else
                    {
                        scintilla.SetStyling(1, StyleString);
                        state = STATE_COMMENT3;
                        //goto REPROCESS;

                    }
                    break;
                case STATE_NUMBER:
                    if (Char.IsDigit(c))
                    {
                        length++;
                    }else if (c=='.')
                    {
                        length++;
                        state = STATE_FLOAT;
                    }
                    else
                    {
                        scintilla.SetStyling(length, StyleNumber);
                        length = 0;
                        state = STATE_UNKNOWN;
                        startPos--;
                        //goto REPROCESS;
                    }
                    break;
                case STATE_FLOAT:
                    if (char.IsDigit(c))
                    {
                        length++;
                    }
                    else
                    {
                        scintilla.SetStyling(length, StyleNumber);
                        length = 0;
                        state = STATE_UNKNOWN;
                        startPos--;
                        //goto REPROCESS;
                    }
                    break;
                case STATE_IDENTIFIER:
                    if (Char.IsLetterOrDigit(c))
                    {
                        length++;
                    }
                    else
                    {
                        var style = StyleIdentifier;
                        var identifier = scintilla.GetTextRange(startPos - length, length);
                        if (keywords.Contains(identifier))
                            style = StyleKeyword;

                        scintilla.SetStyling(length, style);
                        length = 0;
                        state = STATE_UNKNOWN;
                        startPos--;
                        //goto REPROCESS;
                    }
                    break;
            }

            startPos++;
        }
        
    }

    public CSharpLexer(string keywords)
    {
        // Put keywords in a HashSet
        var list = Regex.Split(keywords ?? string.Empty, @"\s+").Where(l => !string.IsNullOrEmpty(l));
        this.keywords = new HashSet<string>(list);
    }
}
