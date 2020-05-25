select t.ID,t.TextOfTweet,t.CreatedDate,a.UserName
from Tweets t
join Users a on t.IdOfAuthor = a.Id

insert Tweets
(TextOfTweet, CreatedDate, IdOfAuthor)
values('text', '02.06.1995', 1)

update Tweets
set TextOfTweet = 'NewText'
where ID = 1

delete Tweets
where ID = 1