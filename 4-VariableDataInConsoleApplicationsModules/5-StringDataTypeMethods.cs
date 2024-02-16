using System.Diagnostics.Metrics;

namespace csharpfoundations;

public class StringDataTypeMethods
{
    public static void Run()
    {
        // Find inside the brackets
        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition + 1, length - 1));

        // Last set of brackets
        message = "(What if) I am (only interested) in the last (set of parentheses)?";
        openingPosition = message.LastIndexOf('(');
        closingPosition = message.LastIndexOf(')');
        length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition + 1, length - 1));

        // Using index of any and a char array
        message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
        char[] openSymbols = { '[', '{', '(' };
        closingPosition = 0;

        while (true)
        {
            openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            if (openingPosition == -1) break;

            string currentSymbol = message.Substring(openingPosition, 1);
            char matchingSymbol = ' ';

            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition + 1, length - 1));
        }

        // Remove()
        string data = "12345John Smith          5000  3  ";
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData);

        // Replace()
        message = "This--is--ex-amp-le--da-ta";
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message);

        // Challenge is to take the input and produce the desired output:
        // Quantity: 5000
        // Output: <h2>Widgets &reg;</h2><span>5000</span>
        const string challengeInput = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
        const string quantStartTag = "span"; const string quantEndTag = "/span";
        const string removeStartTag = "div"; const string removeEndTag = "/div";
        const string replaceTag = "&trade";

        string inner;
        int startIndex = -1;
        int innerLength; int quantStart; int quantEnd;

        // Find quantity
        do
        {
            startIndex = challengeInput.IndexOf('<', startIndex + 1);
            innerLength = challengeInput.Substring(startIndex).IndexOf('>') - 1;
            inner = challengeInput.Substring(startIndex + 1, innerLength);
        } while (inner != quantStartTag);

        quantStart = startIndex + innerLength + 2;

        do
        {
            startIndex = challengeInput.IndexOf('<', startIndex + 1);
            innerLength = challengeInput.Substring(startIndex).IndexOf('>') - 1;
            inner = challengeInput.Substring(startIndex + 1, innerLength);
        } while (inner != quantEndTag);

        quantEnd = startIndex;

        // Printing the quantity
        Console.WriteLine($"Quantity: {challengeInput.Substring(quantStart, quantEnd - quantStart)}");

        // Remove div tags
        startIndex = -1;
        do
        {
            startIndex = challengeInput.IndexOf('<', startIndex + 1);
            innerLength = challengeInput.Substring(startIndex).IndexOf('>') - 1;
            inner = challengeInput.Substring(startIndex + 1, innerLength);
        } while (inner != removeStartTag);

        string challengeOutput = challengeInput.Remove(startIndex, innerLength + 2);

        startIndex = -1;
        do
        {
            startIndex = challengeOutput.IndexOf('<', startIndex + 1);
            innerLength = challengeOutput.Substring(startIndex).IndexOf('>') - 1;
            inner = challengeOutput.Substring(startIndex + 1, innerLength);
        } while (inner != removeEndTag);

        challengeOutput = challengeOutput.Remove(startIndex, innerLength + 2);

        // Replace &trade char with &reg
        startIndex = 0; bool foundChar = false;
        // Finding &trade and marking its spot
        foreach (char ch in challengeOutput.ToCharArray())
        {
            if (ch == replaceTag.ToCharArray()[0])
            {
                int counter = 0;
                foreach (char ch2 in replaceTag.ToCharArray())
                {
                    if (challengeOutput.ToCharArray()[startIndex + counter] != ch2) break;
                    counter++;
                }
                if (counter == replaceTag.Length)
                {
                    foundChar = true;
                    break;
                }
            }
            startIndex++;
        }

        // If found, replace
        if (foundChar)
        {
            challengeOutput = challengeOutput.Substring(0, startIndex) + "&reg" + challengeOutput.Substring(startIndex + replaceTag.Length);
        }
        else
        {
            Console.WriteLine(replaceTag + " not found");
        }
        
        Console.WriteLine($"Output: {challengeOutput}");

        /*
        I have now discovered that Replace() and IndexOf() are overloadable
        they can take strings in addition to chars
        this would have been a whole lot easier if I'd known that lol
        */
    }
}