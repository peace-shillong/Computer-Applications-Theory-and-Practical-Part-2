#include<stdio.h>
#include<conio.h>
#include<time.h>
#include<stdlib.h>
//Multipli two Matrix
void main(){
	int a[50][50],b[50][50],m[50][50],i,j,k,c1,c2,r1,r2;

	clock_t beg,end;
	beg=clock();
	//clrscr();
	printf("Enter rows and Columns.");
	scanf("%d %d",&r1,&c1);
	printf("Enter rows and Columns.");
	scanf("%d %d",&r2,&c2);
	if(r2==c1){
		 for(i=0;i<r1;i++){
			for(j=0;j<c1;j++){
				a[i][j]=rand()%100;
			}
		 }
		 for(i=0;i<r2;i++){
			for(j=0;j<c2;j++){
				b[i][j]=rand()%100;
			}
		 }
		 for(i=0;i<r1;i++){
			for(j=0;j<c2;j++){
				m[i][j]=0;
			}
		 }
		for(i=0;i<r1;i++){
			for(j=0;j<c2;j++){
				for(k=0;k<c2;k++){
					m[i][j]+=a[i][k]*b[k][j];
				}

			}
		 }
		for(i=0;i<r1;i++){
			for(j=0;j<c2;j++){
				printf("\t%d",m[i][j]);
			}
			printf("\n");
		}
	}
	end=clock();
	printf("The total time is %f",difftime(end,beg)/10);

	getch();
}
