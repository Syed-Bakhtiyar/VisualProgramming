# include<stdio.h>
# include<iostream>
# include<conio.h>
# include<string.h>
using namespace std;
void function(char *,int);
int main(void){
system("CLS");
char name[]="";
gets(name);
int len = strlen(name);
function(name,len);
getch();
return 0;

}

void function(char *a,int len){
for(int i=0;i<=len;i++){
	printf("%c",*(a+i));
}

}