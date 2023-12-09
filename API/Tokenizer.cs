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
    
    private char Peek(string program, in ulong currentOffset, in long offset = 0) => program[currentOffset + offset];
    
    private bool IsOperator(in char ch)
    {
      bool isOperator;

      switch (ch)
      {
        case '!':
        case '@':
        case '#':
        case '$':
        case '%':
        case '^':
        case '&':
        case '*':
        case '(':
        case ')':
        case '-':
        case '_':
        case '+':
        case '=':
        case '{':
        case '}':
        case '|':
        case '\\':
        case '[':
        case ']':
        case ';':
        case ':':
        case '"':
        case '\'':
        case '<':
        case '>':
        case ',':
        case '.':
        case '/':
        case '?':
        case '`':
        case '~':
            isOperator = true;
            break;

        default:
            isOperator = false;
            break;
      }

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