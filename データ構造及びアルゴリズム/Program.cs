char[] strings = { 'A', 'B', 'B', 'B', 'B', 'A', 'A', 'B', 'A', 'A', 'A', 'A', 'A', 
    'B', 'B', 'B', 'B', 'A', 'A', '#' };
int i, j, cnt;
i = 1;
j = 1;
cnt = 1;
do
{
    j = j + 1;
    if (strings[j - 1] == strings[j])
    {
        cnt = cnt + 1;
    }
    else
    {
        if (cnt >= 4)
        {
            strings[i] = strings[j - 1];
            strings[i + 1] = '*';
            strings[i + 2] = Convert.ToChar(cnt);
            i = i + 3;
        }
        else
        {
            do
            {
                strings[i] = strings[j - cnt];
                i = i + 1;
                cnt = cnt - 1;
            } while (i != 1);
            cnt = 1;
        }
    }
} while (strings[j] != '#') ;
strings[i] = strings[j];
strings[j] = ' ';

