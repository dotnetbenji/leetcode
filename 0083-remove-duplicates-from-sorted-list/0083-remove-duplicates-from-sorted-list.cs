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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode cur = head;
        while(cur?.next != null)
        {
            if(cur.next.val != cur.val)
            {
                cur = cur.next;
                continue;
            }

            cur.next = cur.next.next;
        }

        return head;
    }
}