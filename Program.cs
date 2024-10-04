using CodePrepare.Array;
#region"Array---------------------"

#region "Write a function to reverse the given array. "

var Arr_No1 = new No1_ArrayReverse();
int[] Arr_No1res1 = Arr_No1.ArrayReverse(new int[] { 1, 2, 3, 4, 5 });//odd size
Console.WriteLine(string.Join(", ", Arr_No1res1));

int[] Arr_No1res5 = Arr_No1.ArrayReverse(new int[] { 5,4, 3, 2, 1 });//odd size
Console.WriteLine(string.Join(", ", Arr_No1res5));

int[] Arr_No1res6 = Arr_No1.ArrayReverse(new int[] { 4,3,2,1 });//even size
Console.WriteLine(string.Join(", ", Arr_No1res6));

int[] Arr_No1res2 = Arr_No1.ArrayReverse(new int[] { 1, 2, 3, 4});//even size
Console.WriteLine(string.Join(", ", Arr_No1res2));

int[] Arr_No1res3 = Arr_No1.ArrayReverse(new int[] { 1 });//one element
Console.WriteLine(string.Join(", ", Arr_No1res3));

int[] Arr_No1res4 = Arr_No1.ArrayReverse(new int[] { });//zero size
Console.WriteLine(string.Join(", ", Arr_No1res4));

#endregion

#region "Calculate the sum of all elements in the array. "
var Arr_No2 = new No2_ArraySum();
int No2res1 = Arr_No2.ArrSum(new int[] { 1, 2, 3, 4, 5 });
Console.WriteLine(string.Join(", ", No2res1));

int No2res2 = Arr_No2.ArrSum(new int[] {3});//one element
Console.WriteLine(string.Join(", ", No2res2));

int No2res3 = Arr_No2.ArrSum(new int[] {  });//zero
Console.WriteLine(string.Join(", ", No2res3));

#endregion

#region"Given a sorted array, remove the duplicates in-place and return the new length."
var Arr_No3 =new No3_ArraySorted();
bool Arr_No3res = Arr_No3.checkSorted(new int[] {1,2,3,4});//sorted array
Console.WriteLine(string.Join(", ", new int[] { 1, 2, 3, 4 }) + Arr_No3res);

bool Arr_No3res2 = Arr_No3.checkSorted(new int[] { 1, 2, 2, 4, 5 ,5,6});//sorted array with duplicate
Console.WriteLine(string.Join(", ", new int[] { 1, 2, 2, 4, 5, 5, 6 }) + Arr_No3res2);

bool Arr_No3res3 = Arr_No3.checkSorted(new int[] {4,1,3,5,6 });//unsorted array
Console.WriteLine(string.Join(", ", new int[] { 4, 1, 3, 5, 6 }) + Arr_No3res3);

bool Arr_No3res4 = Arr_No3.checkSorted(new int[] { 4,4, 1, 3, 5, 6 });//unsorted array duplicate
Console.WriteLine(string.Join(", ", new int[] { 4, 4, 1, 3, 5, 6 }) + Arr_No3res4);

bool Arr_No3res5 = Arr_No3.checkSorted(new int[] { 4});//one element
Console.WriteLine(string.Join(", ", new int[] { 4 }) + Arr_No3res5);

bool Arr_No3res6 = Arr_No3.checkSorted(new int[] {  });//zero element
Console.WriteLine(string.Join(", ", new int[] {  }) + Arr_No3res6);


#endregion
#region"●	Given a sorted array, remove the duplicates in-place and return the new length. "
var ArrNo4 = new No4_MoveDuplicate();
int[] arr1 = { 1, 1, 2 ,3,4,4,5};
int res = ArrNo4.removeZero(arr1);//duplicate
int[] arr2 = { 1, 2,3};
int ArrNo4res1 = ArrNo4.removeZero(arr2);//without duplicate
int[] arr3 = { 1};
int ArrNo4res2 = ArrNo4.removeZero(arr3);//without duplicate
int[] arr4 = { };
int ArrNo4res3 = ArrNo4.removeZero(arr4);//without duplicate
#endregion
#region"●	Given an array, move all zeros to the end while maintaining the relative order of non-zero elements. "
var Arr_No5 = new No5_MoveZero();
int[] Arr_No5res = Arr_No5.MoveZero(new int[] {1,2,0,4,6,0,9,0,8,0});
Console.WriteLine(string.Join(", ", new int[] { 1, 2, 0, 4, 6, 0, 9, 0, 8, 0 }) +"--->" +string.Join(", ", Arr_No5res));
int[] Arr_No5res1 = Arr_No5.MoveZero(new int[] { 0 });
Console.WriteLine(string.Join(", ", new int[] { 0 }) + "--->" + string.Join(", ", Arr_No5res1) );
int[] Arr_No5res2 = Arr_No5.MoveZero(new int[] {  });
Console.WriteLine(string.Join(", ", new int[] { }) + "--->" + string.Join(", ", Arr_No5res2) );
#endregion

#region"●	Identify the second largest element in the array."
var ArrNo6 = new No6_SecondLargest();
int ArrNo6_res = ArrNo6.sendLargest(new int[] { 6,1, 4, 8,5, 3, 3, 7, 6  });//with duplicate
Console.WriteLine(string.Join(", ", new int[] { 6, 1, 4, 8, 5, 3, 3, 7, 6 }) + "--->" + ArrNo6_res);

int ArrNo6_res1 = ArrNo6.sendLargest(new int[] { 5,9,3,4,11,8,12 });
Console.WriteLine(string.Join(", ", new int[] { 5, 9, 3, 4, 11, 8, 12 }) + "--->" + ArrNo6_res1);
#endregion

#region"●	Given an array, rotate it to the right by k steps."
var ArrNo7 = new No7_RotateKth();
int[] ArrNo7Arr ={ 1, 2, 3, 4, 5, 6, 7 };
ArrNo7.rotateArr(ArrNo7Arr,3);
Console.WriteLine(string.Join(", ", new int[] { 1, 2, 3, 4, 5, 6, 7 }) + "--->" + string.Join(", ", ArrNo7Arr));
int[] ArrNo7Arr1 = { 4,5,6,7,8,9,9 };
ArrNo7.rotateArr(ArrNo7Arr1, 4);
Console.WriteLine(string.Join(", ", new int[] { 4, 5, 6, 7, 8, 9, 9 }) + "--->" + string.Join(", ", ArrNo7Arr1));
int[] ArrNo7Arr2 = { 1, 2, 3, 4 };
ArrNo7.rotateArr(ArrNo7Arr2, 5);
Console.WriteLine(string.Join(", ", new int[] { 1,2,3,4 }) + "--->" + string.Join(", ", ArrNo7Arr2));//k is bigger than array size
#endregion
#region"Given an array of size n with elements from 1 to n, find the missing number."
var ArrNo8 = new No8_ArrayMissNo();
int[] ArrNo8Arr = { 1, 2,3,4, 5, 7 };
int ArrNo8res = ArrNo8.missnumber(ArrNo8Arr,7);
Console.WriteLine(string.Join(", ", ArrNo8Arr)+ "--->" + ArrNo8res);
int[] ArrNo8Arr1 = {3, 4, 5,1, 2,6,7 };
int ArrNo8res1 = ArrNo8.missnumber(ArrNo8Arr1, 8);
Console.WriteLine(string.Join(", ", ArrNo8Arr1) + "--->" + ArrNo8res1);
int[] ArrNo8Arr2 = { 1,2,3 };
int ArrNo8res2 = ArrNo8.missnumber(ArrNo8Arr2,3);
Console.WriteLine(string.Join(", ", ArrNo8Arr2) + "--->" + ArrNo8res2);
#endregion

#region"Given an array, find all pairs that sum up to a specific target."

int[] ArrNo9nums = { 1, 5, 7, -1, 5 };
var ArrNo9= new No9_ArrayFindSumPair();
List<List<int>> ArrNo9res = ArrNo9.findPair(ArrNo9nums, 6);
int[] ArrNo9nums2 = { 3, 2, 3, 4, 5 };
List<List<int>> ArrNo9res2 = ArrNo9.findPair(ArrNo9nums2, 6);
#endregion

#region"Given an array, find the smallest and largest numbers."

int[] ArrNo10nums = { 1, 5, 7, -1, 5 };
var ArrNo10 = new No10_SmallLargeNo();
int[] No10res1 =ArrNo10.getSmallandLarge(ArrNo10nums);
Console.WriteLine(string.Join(", ", ArrNo10nums) + "--->" + string.Join(", ", No10res1));
int[] ArrNo10nums1 = { 1, 2,1};
int[] No10res2 = ArrNo10.getSmallandLarge(ArrNo10nums1);
Console.WriteLine(string.Join(", ", ArrNo10nums1) + "--->" + string.Join(", ", No10res2));
#endregion

#region"Sort an Array of 0s and 1s."


var ArrNo11 = new No11_ArrayZeroandOnesort();
int[] ArrNo11nums = { 0, 1, 0, 0, 1 };
ArrNo11.sortArr(ArrNo11nums);
Console.WriteLine(string.Join(", ", new int[] { 0, 1, 0, 0, 1 }) + "--->" + string.Join(", ", ArrNo11nums));
int[] ArrNo11nums1 = { 0, 0, 0, 1, 1 };
ArrNo11.sortArr(ArrNo11nums);
Console.WriteLine(string.Join(", ", new int[] { 0, 0, 0, 1, 1 }) + "--->" + string.Join(", ", ArrNo11nums1));
#endregion
#endregion