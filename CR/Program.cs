string[] Array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] Array2 = new string[4] {"1234", "1567","-2", "computer science"};
string[] Array3 = new string[3] {"Russia", "Denmark", "Kazan"};

string[] Arrayanswer = new string[Array1.Length];
int b = 0;

for (int i = 0; i < Array1.Length; i++) {
    if (Array1[i].Length <= 3) {
        Arrayanswer[b] = Array1[i];
        Console.Write(Arrayanswer[b]);
        Console.Write(" ");
        b++;
}
}
Console.WriteLine();

