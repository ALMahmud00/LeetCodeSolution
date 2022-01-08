/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
     public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return SingleNodeBySumTwoNode(l1,l2,0);
        }

        public static ListNode SingleNodeBySumTwoNode(ListNode? nodeA, ListNode? nodeB, int res)
        {
            int remainder = (nodeA == null ? 0 : nodeA.val) + (nodeB == null ? 0 : nodeB.val) + res;

            res = remainder / 10;
            remainder = remainder % 10;

            if (nodeA == null && nodeB == null && res == 0 && remainder == 0)
            {
                return null;
            }
            return new ListNode()
            {
                val = remainder,
                next = SingleNodeBySumTwoNode(nodeA == null ? null : nodeA.next, nodeB == null ? null : nodeB.next, res)
            };
        }
}