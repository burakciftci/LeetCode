using LeetCode;
using static LeetCode.MergeKSortedListsService;
var service = new MergeKSortedListsService();

// Create example input: [[1,4,5],[1,3,4],[2,6]]
ListNode[] lists = new ListNode[]
        {
            service.CreateList(new int[] { 1, 4, 5 }),
            service.CreateList(new int[] { 1, 3, 4 }),
            service.CreateList(new int[] { 2, 6 })
        };

var merged = service.MergeKLists(lists);
service.PrintList(merged);



