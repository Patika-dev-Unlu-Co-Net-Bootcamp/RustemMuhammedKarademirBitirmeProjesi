--Yeni kayit olan kullanicalara User yektisi verir 

USE [FinalProjectDb]
ALTER trigger [dbo].[trg_YeniKayıtOlanKullanıcıyaOtomatikRolAtama]
on [dbo].[Users]
for insert
as
begin
	declare @UserId int
	
	select @UserId=Id from inserted
	
	insert into UserOperationClaims
	values(@UserId,1)
end