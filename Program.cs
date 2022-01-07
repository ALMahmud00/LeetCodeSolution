using System;

namespace LeetCode
{
    

    class Program
    {
        static void Main(string[] args)
        {

            var ln1 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 0,
                    next = new ListNode()
                    {
                        val = 0,
                        next = new ListNode()
                        {
                            val = 0,
                            next = new ListNode()
                            {
                                val = 0,
                                next = new ListNode()
                                {
                                    val = 0,
                                    next = new ListNode()
                                    {
                                        val = 0,
                                        next = new ListNode()
                                        {
                                            val = 0,
                                            next = new ListNode()
                                            {
                                                val = 0,
                                                next = new ListNode()
                                                {
                                                    val = 0,
                                                    next = new ListNode()
                                                    {
                                                        val = 0,
                                                        next = new ListNode()
                                                        {
                                                            val = 0,
                                                            next = new ListNode()
                                                            {
                                                                val = 0,
                                                                next = new ListNode()
                                                                {
                                                                    val = 0,
                                                                    next = new ListNode()
                                                                    {
                                                                        val = 0,
                                                                        next = new ListNode()
                                                                        {
                                                                            val = 0,
                                                                            next = new ListNode()
                                                                            {
                                                                                val = 0,
                                                                                next = new ListNode()
                                                                                {
                                                                                    val = 0,
                                                                                    next = new ListNode()
                                                                                    {
                                                                                        val = 0,
                                                                                        next = new ListNode()
                                                                                        {
                                                                                            val = 0,
                                                                                            next = new ListNode()
                                                                                            {
                                                                                                val = 0,
                                                                                                next = new ListNode()
                                                                                                {
                                                                                                    val = 0,
                                                                                                    next = new ListNode()
                                                                                                    {
                                                                                                        val = 0,
                                                                                                        next = new ListNode()
                                                                                                        {
                                                                                                            val = 0,
                                                                                                            next = new ListNode()
                                                                                                            {
                                                                                                                val = 0,
                                                                                                                next = new ListNode()
                                                                                                                {
                                                                                                                    val = 0,
                                                                                                                    next = new ListNode()
                                                                                                                    {
                                                                                                                        val = 0,
                                                                                                                        next = new ListNode()
                                                                                                                        {
                                                                                                                            val = 0,
                                                                                                                            next = new ListNode()
                                                                                                                            {
                                                                                                                                val = 0,
                                                                                                                                next = new ListNode()
                                                                                                                                {
                                                                                                                                    val = 0,
                                                                                                                                    next = new ListNode()
                                                                                                                                    {
                                                                                                                                        val = 1,
                                                                                                                                        next = null
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            var ln2 = new ListNode()
            {
                val = 5,
                next = new ListNode()
                {
                    val = 6,
                    next = new ListNode()
                    {
                        val = 4,
                        next = null  
                    }
                }
            };
            //var res = AddTwoNumbers(ln1, ln2);
            
            int[] res = new int[] { -1,0};
            var dd = SingleNumber(res);
            Console.WriteLine("");
        }

        public int SingleNumber(int[] nums)
        {

        }
        public static int[] SingleNumber(int[] nums)
        {
            int[] res = new int[2];
            int i, j, k = 0;
            for (i = 0; i < nums.Length; i++)
            {
                for(j = 0; j<nums.Length; j++)
                {
                    if(nums[i] == nums[j] && i != j)
                    {
                        break;
                    }
                }
                if (j == nums.Length)
                {
                    res[k++] = nums[i];
                }
                if(k == 2)
                {
                    break;
                }
            }

            return res;
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = SingleNodeBySumTwoNode(l1,l2,0);

            var chk1 = consoleNode(l1); Console.WriteLine();
            var chk2 = consoleNode(l2); Console.WriteLine();
            var chk = consoleNode(result);
            return result;
        }

        public static ListNode SingleNodeBySumTwoNode(ListNode? nodeA, ListNode? nodeB, int remainder)
        {
            int res;
            res = (nodeA == null ? 0 : nodeA.val) + (nodeB == null ? 0 : nodeB.val) + remainder;

            remainder = res / 10;
            res = res % 10;

            if (nodeA == null && nodeB == null && remainder == 0 && res == 0)
            {
                return null;
            }
            return new ListNode()
            {
                val = res,
                next = SingleNodeBySumTwoNode(nodeA == null ? null : nodeA.next, nodeB == null ? null : nodeB.next, remainder)
            };
        }
        public static ListNode consoleNode(ListNode LN)
        {
            if (LN == null)
            {
                return null;
            }
            Console.Write(LN.val.ToString()+" ");
            return consoleNode(LN.next);
        }
        public static int FindNumberFromListNode(ListNode LN, int mul)
        {
            if (LN.next == null)
            {
                return LN.val;
            }
            return (LN.val * mul) + FindNumberFromListNode(LN.next, mul * 10);
        }

        public static ListNode ReverseArray(int num)
        {
            return new ListNode()
            {
                val = num / 10 == 0 ? num : num % 10,
                next = num / 10 == 0 ? null : ReverseArray(num / 10)
            };
        }
        public static int[] MinOperations(string boxes) //1769. Minimum Number of Operations to Move All Balls to Each Box
        {
            int[] result = new int[boxes.Length];

            for(int i = 0; i < boxes.Length; i++)
            {
                int sum = 0;
                for(int j = 0; j < boxes.Length; j++)
                {
                    if (boxes[j]=='1')
                    {
                        sum += Math.Abs(i - j);
                    }
                }
                result[i] = sum;
            }

            return result;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

/* Write your T-SQL query statement below 
DECLARE @intCount BIGINT
SET @intCount = (SELECT COUNT(*) FROM Seat)

IF(@intCount % 2 != 0)
BEGIN
   SET @intCount = @intCount-1
END

WHILE(@intCount > 0)
BEGIN
    DECLARE @temp NVARCHAR(MAX)


    SET @temp = (SELECT student FROM Seat
    WHERE id = @intCount)
    
    UPDATE Seat
    SET student = (SELECT student FROM Seat
    WHERE id = @intCount - 1)
    WHERE id = @intCount


    UPDATE Seat
    SET student = @temp
    WHERE id = @intCount - 1


    SET @temp = @temp - 2
END
SELECT id, student FROM Seat

    */