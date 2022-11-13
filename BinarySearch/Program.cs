//Array.BinarySearch();
int[] sortedArray = { 1, 2, 3, 4, 5, 6 };
int item = 5;
Console.WriteLine($"Index: {Array.BinarySearch(sortedArray, item)}");
Console.ReadLine();


//My BinarySearch
int min = 0;
int max = sortedArray.Length;
int found = -1;
while (min <= max) {
    int mid = (min + max) / 2;
    if (item == sortedArray[mid]) {
        found = ++mid;
    } else if (item < sortedArray[mid]) {
        max = mid - 1;
    } else {
        min = mid + 1;
    }
}
Console.WriteLine($"Found {found}");