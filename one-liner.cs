using System.Linq;
class Program { static void Main(string[] args) { string text = @"The quickest way to learn C Sharp"; int startIndex = 6; int count = 3; Console.WriteLine("Start index: {0}, Count: {1}", startIndex, count); Console.WriteLine("Text before cut:"); TextContext context = new TextContext(); context.SetRange(text, startIndex, count); Console.WriteLine("Text after cut:", context.TrimmedText); } }
public class TextContext { private StringReader reader; public bool IsAtEndOfLine { get; set; } public char CurrentChar { get; private void ReadNextChar() { if (!IsAtEndOfLine && !reader.Read()) throw new EndOfStreamException(); CharChars ch = Encoding.UTF8.GetString(reader.Buffer, reader.Column - 1, reader.Row); char chTemp; if (ch == '$') { Chars = '\r'; } else if (ch == '#') { switch (nextchar()) { case '{': IndentLevel++; break; case '(': ParenthesesDepth++; break; case ')': ParenthesesDepth--; break; case '}': IndentLevel--; break; case ',': nextcomma(); break; case ';': IsInParameterOrFieldDeclaration(); } else if (ch == '.') { currenttoken = TokenTypeEnum.LitValueString; currentpos = reader.Position + 1; } else if (ch == '/') { switch (nextchar()) { case '/': DoSingleSlashComment(); break; case '*': StartMultilineComment(); break; } } else if (ch == '@') { SkipToCSharpNewline('\r', '\n'); goto DoneWithToken; } else if (ch == '-') { Chars = '-'; } else if (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z' || ch == '_') { } else { donewithtoken = true; } } } protected void NextChar() { ReadNextChar(); if (donewithtoken) return; else if (currenttoken != TokenTypeEnum.None && (IsAtEndOfLine || !Chars.Contains(CurrentChar))) throw new FormatException(); }

' the third string is just not colourmarked automatically, but this is all clear in the process of the editing this code
