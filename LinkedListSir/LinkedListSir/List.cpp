#include<iostream>
#include<stdio.h>
#include<conio.h>
#include<alloc.h>
#include<process.h>
using namespace std;
void create();
void display();
void del(int);
void insert();
void count();
void search_a_node();
void reverse();
void sort();
void add_at_beg();
void add_after(int,int);

struct node
{
	  int info;
	  struct node *link;
}*start=NULL;

int data,item,n1,pos,i,m;
void main()
{
	  int n;
	  clrscr()
printf("      SINGLY LINKED LIST       \n\n");
	  while(1)
	  {
printf("\n-------------------------- MAIN MENU ----------------------\n");
		   printf("\n\n1.CREATE.");
		   printf("\n\n2.ADD_AT_BEG.");
		   printf("\n\n3.ADD_AFTER.");
		   printf("\n\n4.SORT.");
		   printf("\n\n5.DELETE.");
		   printf("\n\n6.SEARCH A NODE.");
		   printf("\n\n7.COUNT.");
		   printf("\n\n8.REVERSE.");
		   printf("\n\n9.DISPLAY.");
		   printf("\n\n10.EXIT.");
		   printf("\n\nEnter Your Choice : ");
		   scanf("%d",&n);
		   switch(n)
		   {
			     case 1:
printf("\n\n----CREATION OF A LIST-------`\n");
				      create();
				      break;

			     case 2:
printf("\n\n----- ADD AT BEGINNING------\n\n");
				      add_at_beg();
				      break;

			     case 3:
printf("\n\n---- ADD AFTER -------\n\n");
printf("\n\nEnter the element to be added : ");
scanf("%d",&data);
printf("\n\nAfter which node the element is to be added : ")
scanf("%d",&pos);
add_after(pos,data);
break;

case 4:
sort();	
break;
case 5:
printf("\n\n----- DELETION -----\n\n");
printf("\nEnter the element to be deleted : ");
scanf("%d",&data);
del(data);
break;

case 6:
search_a_node();
break;

case 7:
count();
break;

case 8:
reverse();
break;

			     case 9:
printf("\n\n----- DISPALYING  -----\n\n");
display();
break;

case 10:
exit(1);

default:
printf("\n\nINVALID ENTRY !!!!!! TRY AGAIN!!!!!!!\n");
		   }
	  }
}


void create()
{
	  struct node *q, *tmp;
	  int i,n;
	  printf("\nEnter element : ");
	  scanf("%d",&data);
	  tmp=new node;
	  tmp->info=data;
	  tmp->link=NULL;
	  if(start==NULL)
		   start=tmp;
	  else
	  {       q=start;
		   while(q->link!=NULL)
			     q=q->link;

		   q->link=tmp;
	  }
}


void  display()
{       struct node *q;
	  if(start==NULL)
	  {
		   printf("\n--------------------\n");
		   printf("\nLIST IS EMPTY\n");
		   printf("\n-----------------------\n");

	  }
	  else
	  {
		   q=start;
		   while(q!=NULL)
		   {
			     printf("%d\t",q->info);
			     q=q->link;
		   }

	  }
}


void count()
{
	  struct node *q, *tmp;
	  int cnt=1;
	  if(start==NULL)
	  {
printf("\n----------------------------\n");
		   printf("\nLIST IS EMPTY\n");
		   printf("\n----------------------\n");
	  }
	  else
	  {
		   q=start;
printf("\n\n--NUMBER OF NODES IN THE LIST --\n\n");
		   while(q->link!=NULL)
		   {
			     cnt=cnt++;
			     q=q->link;
		   }
		   printf("%d\t",cnt);
	  }

}
void search_a_node()
{
	  struct node *q,*tmp;
	  int i=0;
	  printf("\n\n------- ----------------- SEARCHING--------------------\n\n");
	  display();
	  printf("\n\nEnter the element to be searched :");
	  scanf("%d",&item);
	  tmp=start;

	  while(tmp!=NULL)
	  {
		   if(tmp->info==item)
		   {
printf("\n ELEMENT %d  FOUND AT LOCATION : %d\n",item,i+1);
			     return;
		   }
		   tmp=tmp->link;
		   i++;

	  }
	  if(tmp->link==NULL)
		   printf("\n ELEMENT %d  NOT FOUND\n",item);
		   return;
}


void add_at_beg()
{
	  struct node *q,*tmp;
	  printf("\n\nEnter the element to be added :");
	  scanf("%d",&data);
	  tmp=new node;
	  tmp->info=data;
	  tmp->link=start;
	  start=tmp;
printf("\n\n----- ELEMENTS IN THE LIST AFTER ADD_Beg ---\n\n");
	  display();
}

void add_after(int pos,int data)
{
	  struct node *tmp,*q,*r;
	  r=start;
	  for(i=1;i<=pos;i++)
	  {
		   q=r;
		   r=r->link;
	  }
	  tmp=new node;
	  tmp->info=data;
	  q->link=tmp;
	  q=tmp;
	  q->link=r;
printf("\n\n-------------- ELEMENTS IN THE LIST AFTER ADD_AFTER -------\n\n");
	  display();
	  return;
}


void del(int data)
{
	  struct node *q,*tmp;
	  if(start->info==data)
	  {
		   tmp=start;
		   start=start->link;
		   free(tmp);

printf("\n\n------- ELEMENTS IN THE LIST AFTER DELEION OF FIRST NODE ----\n\n");
		   display();
		   return;
	  }
	  q=start;
	  while(q->link->link!=NULL)
	  {
		   if(q->link->info==data)
		   {
			     tmp=q->link;
			     q->link=tmp->link;
			     free(tmp);
printf("\n\n----------------------- ELEMENTS IN THE LIST AFTER DELEION OF MIDDLE NODE -------\n\n");
			     display();
			     return;
		   }
		   q=q->link;
	  }
	  if(q->link->info==data)
	  {
		   tmp=q->link;
		   q->link=NULL;
		    free(tmp);
printf("\n\n--------------------- ELEMENTS IN THE LIST AFTER DELEION OF LAST NODE ---\n\n");
		   display();
		   return;
	  }
printf("\n\n------ ELEMENT NOT FOUND ---\n\n");

}

void reverse()
{
	  struct node *p1,*p2,*p3;
printf("\n\n------ORIGINAL LIST --------\n\n");
	  display();
	  p1=start;
	  p2=p1->link;
	  p3=p2->link;
	  p1->link=NULL;
          p2->link=p1;
          while(p3!=NULL)
          {
                   p1=p2;
                   p2=p3;
                   p3=p3->link;
                   p2->link=p1;
          }
          start=p2;
          printf("\n\n--- REVERSED LIST ----\n\n");
          display();

}


void sort()
{
          struct node *q,*r;
          int c;
          printf("\n\n-- ORIGINAL LIST ---\n\n");
          display();
          if(start==NULL)
          {
                   printf("\n\n---------\n\n");
                   printf("LIST IS EMPTY");
                   printf("\n\n----------\n\n");
          }
          else
          {
         for(q=start;q>link!=NULL;q=q->link)
                   {
         for(r=q->link;r!=NULL;r=r->link)
                   if(q->info > r->info)
         {
          c=q->info;
          q->info=r->info;
          r->info=c;
                  }  
printf("\n\n---- SORTED LIST ------\n\n");
                   display();
                   return;
          }
}