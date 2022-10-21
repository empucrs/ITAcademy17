//ARRAY UNIDIMENSIONAL
int [] valores = new int[5];
Console.WriteLine("O tamanho do vetor valores é " + valores?.Length);

for(int i=0; i<valores.Length; i++){
    Console.WriteLine("O valor contido na posicao {0} do vetor é {1}", i, valores[i]);
}

//ARRAY MULTIDIMENSIONAL (TRIDIMENSIONAL)
int [,,] matriz = new int[5,5,5];

for(int x=0; x<5; x++)
  for(int y=0; y<5; y++)
    for(int z=0; z<5; z++)
    Console.WriteLine("O valor contido na posicao [{0},{1},{2}] da matriz é {3}", x, y, z, matriz[x,y,z]);

//JAGGED ARRAY
int [][] jaggedArray = new int[5][];
jaggedArray[0] = new int [2];
jaggedArray[1] = new int [5];
jaggedArray[2] = new int [3];
jaggedArray[3] = new int [6];
jaggedArray[4] = new int [2];

for(int x=0; x<jaggedArray.Length; x++){
  Console.WriteLine("Linha{0} possui {1} colunas;", x, jaggedArray[x].Length);
  for(int y=0; y<jaggedArray[x].Length; y++)
    Console.WriteLine($"  Jagged[{x}],[{y}]: {jaggedArray[x][y]}");
  Console.WriteLine();
}
