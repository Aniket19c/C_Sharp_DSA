using System;

namespace DSA_Solutions
{
    public class TrappedWater
    {
        public int Trap(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int leftMax = height[left];
            int rightMax = height[right];
            int water = 0;

            while (left < right)
            {
                if (leftMax < rightMax)
                {
                    left++;
                    leftMax = Math.Max(leftMax, height[left]);
                    water += leftMax - height[left];
                }
                else
                {
                    right--;
                    rightMax = Math.Max(rightMax, height[right]);
                    water += rightMax - height[right];
                }
            }

            return water;
        }
    
    }
}
