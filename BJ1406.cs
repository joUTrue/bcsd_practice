//jO_U.true
//BaekJoon 1406
using System.Text;

LinkedList<char> list = new LinkedList<char>();
string input = Console.ReadLine();
int M;

for (int i = 0; i < input.Length; i++)
{
    list.AddLast(input[i]);
}

LinkedListNode<char> cursor = new LinkedListNode<char>('0');
list.AddLast(cursor);
M = Int32.Parse(Console.ReadLine());

for (int i = 0; i < M; i++)
{
    string key = Console.ReadLine();
    switch (key)
    {
        case "L":
            if (cursor == list.First)
            {
                break;
            }
            LinkedListNode<char> tmp = cursor.Previous;
            list.Remove(cursor.Previous);
            list.AddAfter(cursor, tmp);
            break;

        case "D":
            if (cursor == list.Last)
            {
                break;
            }
            LinkedListNode<char> tmp2 = cursor.Next;
            list.Remove(cursor.Next);
            list.AddBefore(cursor, tmp2);
            break;

        case "B":
            if (cursor == list.First)
            {
                break;
            }
            list.Remove(cursor.Previous);
            break;

        default:
            if (key[0] == 'P')
            {
                list.AddBefore(cursor, key[2]);
            }
            break;
    }
}

list.Remove(cursor);
cursor = list.First;
StringBuilder stringBuilder = new StringBuilder();
for (int i = 0; i < list.Count; i++)
{
    stringBuilder.Append(cursor.Value);
    cursor = cursor.Next;
}
Console.WriteLine(stringBuilder);