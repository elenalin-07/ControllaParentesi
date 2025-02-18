bool controllaParentesi (string e)
{
    int a = 0, c = 0;
    for (int i = 0; i < e.Length; i++)
    {
        if(e[i] == '(')
        {
            a++;
        }
        else if (e[i] == ')')
        {
            c++;
            if (c > a)
            {
                return false;
            }
        }
    }
    if (e[0] == e[e.Length - 1] && e[0] == ')' && a != c)
    {
        return false;
    }
    return true;
}
Console.WriteLine("inserisci un'espressione numerica");
string e = Console.ReadLine();
Console.WriteLine(controllaParentesi(e));
