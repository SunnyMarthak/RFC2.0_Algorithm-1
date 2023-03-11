string[] data = File.ReadAllLines("../../../Large_Input.txt");
int dataLength = int.Parse(data[0]);
int[][] Sizes = new int[dataLength][];
for (int i = 0; i < dataLength; i++)
    Sizes[i] = data[i + 1].Trim().Split(" ").Where(x => x.Trim().Length > 0).Select(int.Parse).ToArray();
int[][] SortedSizes = Sizes.OrderBy(x => x[0]).ThenByDescending(x => x[1]).ThenBy(x => x[2]).ToArray();
for (int i = 0; i < dataLength; i++)
    Console.WriteLine(string.Join(",", SortedSizes[i]));