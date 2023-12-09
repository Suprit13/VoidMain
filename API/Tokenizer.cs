using System;
using System.Text;

namespace VoidMainAPI
{
  internal class Tokenizer
  {
    internal void Tokenize(string s)
    {
      
    }
  }
  
  internal class Token
  {
    string data;
    ulong lineNumber, charNumber;
    TokenType tokenType;
  }
  
  public enum TokenType 
  {
    WhiteSpace,
    StringLiteral,
    IntegerLiteral,
    Operator,
    Identifier
  }
}