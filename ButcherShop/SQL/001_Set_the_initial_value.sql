insert into UserInformation (UserName,Password,EditedUserID,EditedDatetime)
values ('admin','admin',1,GETDATE());

select * from UserInformation;

insert into Category (CategoryName,Yomigana,SortOrder,EditedUserID,EditedDatetime)
values ('牛肉','ぎゅうにく',1,1,GETDATE());

insert into Category (CategoryName,Yomigana,SortOrder,EditedUserID,EditedDatetime)
values ('豚肉','ぶたにく',2,1,GETDATE());

insert into Category (CategoryName,Yomigana,SortOrder,EditedUserID,EditedDatetime)
values ('鶏肉','とりにく',3,1,GETDATE());

insert into Category (CategoryName,Yomigana,SortOrder,EditedUserID,EditedDatetime)
values ('加工肉','かこうにく',4,1,GETDATE());

insert into Category (CategoryName,Yomigana,SortOrder,EditedUserID,EditedDatetime)
values ('その他','そのた',5,1,GETDATE());

select * from Category;
