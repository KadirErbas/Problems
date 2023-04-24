#!/usr/bin/env python
# coding: utf-8

# In[31]:


myList = ["R","E","V","E","R","S","E"]


# In[32]:


def reverseRecursive(liste, start:int, end:int):
    if start >= end:
        return
    liste[start], liste[end] = liste[end], liste[start]
    reverseRecursive(liste, start+1, end-1)


# In[34]:


reverseRecursive(myList, 0, len(myList)-1)


# In[35]:


myList

