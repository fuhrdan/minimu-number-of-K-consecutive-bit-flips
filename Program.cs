//*****************************************************************************
//** 995. Minimum Number of K Consecutive Bit Flips leetcode                 **
//** I wrote this in C, it works for all cases, but when submitted it        **
//** exceeds the alloted time.  So it doesn't work to solve the problem      **
//*****************************************************************************
//*****************************************************************************
//*****************************************************************************

int minKBitFlips(int* nums, int numsSize, int k) {
    int retNum = 0;
    for(int i = 0; i < numsSize; i++)
    {
        if(nums[i] == 1) continue;
        if(i+k-1 < numsSize)
        {
            for(int j = 0; j < k; j++)
            {
                nums[i+j] = 1 - nums[i+j];
            }
            retNum++;
        }
        else
        {
            return -1;
        }
    }
    return retNum;
}