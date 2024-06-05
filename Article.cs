public static class Article
{
    public static string ConvertToArticleCase(this string input, string exceptions = "")
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        var words = input.ToLower().Split(' ');
        var exceptionWords = exceptions.ToLower().Split(' ');
        var result = new List<string>();

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];
            if (i == 0 || !exceptionWords.Contains(word))
            {
                result.Add(char.ToUpper(word[0]) + word.Substring(1));
            }
            else
            {
                result.Add(word);
            }
        }

        return string.Join(" ", result);
    }
}