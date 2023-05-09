void countApplesAndOranges(int s, int t, int a, int b, int apples_count, int* apples, int oranges_count, int* oranges) {
 int apple_count = 0, orange_count = 0;
    
  /* 
   * int s: starting point of Sam's house
   * int t: ending point of Sam's house
   * int a: location of the apple tree
   * int b: location of the orange tree
   * int apples_count: number of apples thrown
   * int* apples: array containing the distances at which each apple falls from the tree
   * int oranges_count: number of oranges thrown
   * int* oranges: array containing the distances at which each orange falls from the tree
  */
    
    // count the number of apples that fall within the house range
    for (int i = 0; i < apples_count; i++) {
        int apple_pos = a + *(apples + i);
        if (apple_pos >= s && apple_pos <= t) {
            apple_count++;
        }
    }

    // count the number of oranges that fall within the house range
    for (int i = 0; i < oranges_count; i++) {
        int orange_pos = b + *(oranges + i);
        if (orange_pos >= s && orange_pos <= t) {
            orange_count++;
        }
    }

    // print the counts
    printf("%d\n%d", apple_count, orange_count);
}
This implementation counts the number of apples and oranges that fall within the house range, and then prints the counts.
