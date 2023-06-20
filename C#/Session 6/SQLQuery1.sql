Select * from DEPT
Select * from EMP

declare @empname varchar(20)
Set @empname = 'Anurag'
print @empname + cast(10 as varchar)

Select * from EMP where job in(
select job from EMP where  ename = 'SMITH'
)

--logic  
-- givehike('7369',30%) 
-- function --> it will not modify data in table
Select GETDATE()
Select * from Emp

Create proc usp_giveHike
@empid int,
@hike float,
@result int output
as 
if exists(select 1 from emp where EMPNO = @empid)
set @result = 1
else set @result = 0

update emp set sal = (sal + sal * @hike)
where EMPNO = @empid


Select * from emp
declare @r int
exec usp_giveHike 7369,.20,@r output

declare @r int
exec usp_giveHike 7388,.20,@r output



--cursor
--declare,open,read,close,deallocate

declare @id int ,@name Varchar(20)
declare emp_cursor cursor for
select emp.EMPNO, emp.ENAME from emp

--open
open emp_cursor
 --read
fetch next from emp_cursor into @id,@name

--print 'first fetch' + cast(@id as varchar) +@name 
--@@FETCH_STATUS is used to check if there is any more data to be fetched from the cursor. If the value returned by @@FETCH_STATUS is 0, the loop continues.
print @@FETCH_STATUS

while  @@FETCH_STATUS = 0
begin

 if CHARINDEX('a',@name) > 0
 print cast(@id as varchar) +@name 
 --fetch next used to retrieve the next row of data from the cursor. If there are no more rows to be fetched, the loop ends like as (IEnumerable).
 fetch next from emp_cursor into   @id,@name
end

print @@FETCH_STATUS

close emp_cursor
deallocate emp_cursor


--indexes
create table dummy(id int)
insert into dummy values(10);
insert into dummy values(5);
insert into dummy values(100);
insert into dummy values(1);

Select * from dummy

alter table dummy
alter column id int not null

alter table dummy
add primary key(id) 

Select * from dummy
--whenever primary key is added it clustered the table(records will sorted)
--advantage index created automatically
-- index used when we used where claused with index column name

--index 


