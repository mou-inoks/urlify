string URLify(string word)
{
    var newWord = "";
    foreach (var i in word)
    {
        if (i == ' ')
            newWord += "%20";
        else newWord += i;
    }

    return newWord;
}

Console.WriteLine(URLify("This is my world"));
