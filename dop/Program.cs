Console.Clear();
Console.Write("Введите кол-во монеток: ");
int n = int.Parse(Console.ReadLine());
//int[] mas = new int[n];
int r = 0, g = 0;
for (int i = 0; i < n; i++){
    int b = int.Parse(Console.ReadLine());
    //mas[i] = b;
    if (b == 0){
        g++;
    }
    else{
        r++;
    }
}
// int r = 0, g = 0;
// for (int i = 0; i < n; i++)
// { 
//     if(mas[i] == 0){
//         g++;
//     }else{
//         r++;
//     }
// }
if (g > r){
    Console.Write($"Нужно сделать {r} переворотов");
}else{
    Console.Write($"Нужно сделать {g} переворотов");
}