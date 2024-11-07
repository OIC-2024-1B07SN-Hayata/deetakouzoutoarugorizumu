char[] strings = { 'A', 'B', 'B', 'B', 'B', 'A', 'A', 'B', 'A', 'A', 'A', 'A', 'A', 
    'B', 'B', 'B', 'B', 'A', 'A', '#' };
int i, j, cnt;
i = 1;
j = 1;
cnt = 1;
do
{
    j = j + 1;
    if(cnt>=4)
    {
        strings[i] = strings[j-1];
        strings[i + 1] = '*';
        strings[i + 2] = Convert.ToChar(cnt);
        i = i + 3;
    }
}