using System;
using System.Text;
using System.Collections.Generic;

namespace VoidMainAPI
{
  internal class Tokenizer
  {
    internal List<Token> Tokenize(string s)
    {
      
    }
    
    private char Peek(string program, in int currentOffset, in int offset = 0) => program[currentOffset + offset];
    
    private bool IsOperator(in char ch)
    {
            var isOperator = ch switch
            {
                '!' or '@' or '#' or '$' or '%' or '^' or '&' or '*' or '(' or ')' or '-' or '_' or '+' or '=' or '{' or '}' or '|' or '\\' or '[' or ']' or ';' or ':' or '"' or '\'' or '<' or '>' or ',' or '.' or '/' or '?' or '`' or '~' => true,
                _ => false,
            };
            return isOperator;
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