using LeetCode;
using static LeetCode.RemoveNthFromEndService;

var service = new RemoveNthFromEndService();

// Create linked list: 1 -> 2 -> 3 -> 4 -> 5
ListNode head = new ListNode(1,
                            new ListNode(2,
                                new ListNode(3,
                                    new ListNode(4,
                                        new ListNode(5)))));

Console.WriteLine("Original list:");
PrintList(head);

// Remove the 2nd node from the end (which is 4)
head = service.RemoveNthFromEnd(head, 2);

Console.WriteLine("After removing 2nd node from the end:");
PrintList(head);

void PrintList(ListNode head)
{
    while (head != null)
    {
        Console.Write(head.val + " ");
        head = head.next;
    }
    Console.WriteLine();
}