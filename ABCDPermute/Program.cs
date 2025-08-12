class ABCDPermute
{
    private string input;
    ABCDPermute(string input)
    {
        this.input = input;
    }

    void displayPermute()
    {
        for (int i = 0; i < input.Length; i++)
        {
            string res = string.Empty;
            res += input[i].ToString();
            Console.WriteLine(res);
            for (int j = i + 1; j < input.Length; j++)
            {
                res += input[j].ToString();                                
                Console.WriteLine(res);
            }
        }
    }

    static void Main(string[] args)
    {
        string input = "abcd";
        ABCDPermute permute = new ABCDPermute(input);
        permute.displayPermute();
    }
}