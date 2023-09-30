##Bubble Sort Algorithm
-Define an integer variable named "temp" which will be used to temporarily store values during swapping.
-Start a nested for loop with an outer loop running from 0 to the second last index of the array. This outer loop will be used to control the number of passes over the array.
-Within the outer loop, start an inner loop. This inner loop will compare adjacent elements in the array and swap them if they are in the wrong order.
-Within the inner loop, check if the current element is greater than the next element (i.e., nums[i] > nums[i + 1]). If this is true, swap the two elements.
-By completing the inner loop, the smallest element will be moved to the beginning of the array. Repeat this process until all elements are in their correct positions.
-Finally, return the sorted array.
##Merge Sort Algorithm
-The Merge Sort algorithm has a time complexity of O(n log n), which is a very efficient sorting algorithm for large datasets. It sorts the array by splitting it into smaller arrays all the way down to a pair of numbers and then joining them back together.
-The first if in is to determine if there is more than one element in the array. If there is only one element or less, the array is already sorted.
-If there are more than one elements in the array, the array is divided into two halves using a pivot value. The pivot value is the middle index of the array.
-The left half of the array is copied into a new array named left, and the right half of the array is copied into a new array named right.
-The method is called recursively on the left and right halves of the array to sort them.
-After the left and right halves of the array are sorted, the sorted halves are merged using a while loop. The loop compares the elements of the two halves and takes the smaller of the two and places it in a new array named nums. The k index keeps track of the index of the new array, nums, while the i and j indices keep track of the indices of the left and right halves respectively.
-If there are any remaining elements in either the left or the right half of the array after the merging, those elements are copied into the new array, nums.
-Finally, the sorted array is returned.
Author: Csongor Jánosi (cc211049)