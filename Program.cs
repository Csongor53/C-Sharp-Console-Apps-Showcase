namespace Assignment1_Csongor_Janosi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tell User what to do 
            Console.WriteLine("Usage: sort -Bubble \"1,2,(any int>=0)\" or sort -Merge \"1,2,(any int>=0)\"");
            // Make sure input is good
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: sort -Bubble/Merge \"1,4,2,3\"");
                return;
            }

            // take the second element args[1] and split the string by ,
            string[] input = args[1].Split(",");
            // take all the individual numbers and store them in an array as int(s)
            int[] nums = input.Select(int.Parse).ToArray();

            // Get the choosen method from the user and call their respective functions with the number array
            // Check for faulty input and finally write the result
            if (args[0] == "-Bubble")
            {
                BubbleSort(nums);
                Console.Write("After bubble Sort: ");
            }
            else if (args[0] == "-Merge")
            {
                MergeSort(nums);
                Console.Write("After merge Sort: ");
            }
            else
            {
                Console.WriteLine("Invalid sort method specified.");
                return;
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        // Bubble Sort Method handeler
        static void BubbleSort(int[] nums)
        {
            int temp;
            for (int j = 0; j < nums.Length - 1; j++)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
        }

        // Merge Sort Method handeler
        static void MergeSort(int[] nums)
        {
            // Check if there is more than one element in the array
            if (nums.Length > 1)
            {
                // Divide the array into two halves based on pivot value
                int mid = nums.Length / 2;
                int[] left = nums.Take(mid).ToArray();
                int[] right = nums.Skip(mid).ToArray();

                // Recursively sort the two halves
                MergeSort(left);
                MergeSort(right);

                // Merge the sorted halves
                int i = 0, j = 0, k = 0; // i: left, j: right, k: total index
                while (i < left.Length && j < right.Length)
                {
                    // Compare the elements of the two halves
                    if (left[i] < right[j])
                    {
                        // Take the value of nums[k] and then increment k
                        nums[k++] = left[i++];
                    }
                    else
                    {
                        nums[k++] = right[j++];
                    }
                }

                // Copy remaining elements of left half
                while (i < left.Length)
                {
                    nums[k++] = left[i++];
                }

                // Same for right
                while (j < right.Length)
                {
                    nums[k++] = right[j++];
                }
            }
        }
    }
}