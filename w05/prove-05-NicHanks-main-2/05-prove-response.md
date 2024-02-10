**CSE 212 – Programming with Data Structures**

**W05 Prove – Response Document**

------------------------------------------

_It is a violation of BYU-Idaho Honor Code to post or share this document with others or to post it online.  Storage into a personal and private repository (e.g. private GitHub repository, unshared Google Drive folder) is acceptable._

------------------------------------------

**Question 1:**  From Part 1, how did you answer the interview question for the Set Operations problem (should be no more than 30 seconds if spoken aloud)?

purpose/behavior/performance of the task at hand is:
A function to find the intersection of two sets is finding the common element of the list 
by identifying two common hashes. Since this can quickly be done its performance is O(1),
and the behavior for finding intersection is basically just looping through the list untill 
a hash matches another. 

A function with the union properties will basically find all of the common variables of two lists, 
or HashSets. For example, with an O(1) performance it will look for hashes that are duplicates. 

**Question 2:**  From Part 2, how did you answer the interview question for the Find Pairs problem (should be no more than 30 seconds if spoken aloud)?

The two sets can be joined by using something like Union(x,y), this is a great choice to combine two lists that are over lapping as all it really does is find the first duplicate hash and uses that two anchor the two sets tegether. This gives an O(1) performance. 
------------------------------------------

_Remember:  Make sure all of your changes are committed and pushed to the `main` branch of your_ **prove-05-[username]** _repository_

_Also, submit this document and a link to your repository in I-Learn_
