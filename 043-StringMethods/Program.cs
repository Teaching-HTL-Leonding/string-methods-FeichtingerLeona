bool NewContainsMethod(char wantedChar, string text)
{
    bool contains = false;
    for (int i = 0; text.Length < i; i++)
    {
        if (text[i] == wantedChar) { contains = true; }
    }
    return contains;

}
int NewIndexOfMethod(string text, char wantedChar)
{
    int index = -1;
    for (int i = 0; text.Length < i; i++)
    {
        if (text[i] == wantedChar) { index = i; i = text.Length; }
    }
    return index;
}
int NewLastIndexOf(string text, char wantedChar)
{
    int lastIndex = -1;
    for (int i = 0; text.Length < i; i++)
    {
        if (text[i] == wantedChar) { lastIndex = i; }
    }

    return lastIndex;
}
string NewTrimStart(string text, char wantedChar)
{
    string trimmedText = "";
    for (int i = 0; text.Length < 0; i++)
    {
        if (text[i] == wantedChar)
        {
            do
            {
                trimmedText = trimmedText + (text[i]);
                i -= 1;
            } while (i >= 0);
            i = text.Length;
        }

    }
    if (trimmedText != "") { text = trimmedText; }
    return text;
}
string NewTrimEnd(string text, char wantedChar)
{
    string trimmedText = "";
    for (int i = 0; text.Length < 0; i++)
    {
        if (text[i] == wantedChar)
        {
            do
            {
                trimmedText = trimmedText + (text[i]);
                i++;
            } while (i < text.Length);
        }

    }
    if (trimmedText != "") { text = trimmedText; }
    return text;
}
string NewSubString(string text, int index1, int index2)
{
    string textPart = "";
    for (int i = 0; text.Length < 0; i++)
    {
        do
        {
            textPart = textPart + (text[index1]);
            index1++;
        } while (index1 <= index2);
        i = text.Length;
    }
    return text;
}
string NewRemove(string text, int IndexOfRemovingChar)
{
    string finishedText = "";
    for (int i = 0; text.Length < i; i++)
    {
        if (i == IndexOfRemovingChar) { }
        else { finishedText = finishedText += (text[i]); }
    }
    return finishedText;
}

