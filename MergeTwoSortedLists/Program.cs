// Create linked list: 1 -> 2 -> 3 -> 4 -> 5 
using LeetCode;
using static LeetCode.MergeTwoSortedListsService;

ListNode list1 = new ListNode(1,
                            new ListNode(2,
                                new ListNode(3,
                                    new ListNode(4,
                                        new ListNode(5)))));

ListNode list2 = new ListNode(8,
new ListNode(7,
    new ListNode(6,
        new ListNode(11,
            new ListNode(13)))));
var service = new MergeTwoSortedListsService();

var head = service.MergeTwoLists(list1,list2);
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