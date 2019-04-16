Declare @t TABLE(
    ID  INT IDENTITY PRIMARY KEY,
    Layout VARCHAR(MAX)
)
INSERT INTO @t(Layout)
--SELECT 'Test_2019-03-21_SPIN_201904030510_5836'
select top 2   option_fileName from [10.xxx.xxx.xx].[Yxxxxe].[dbo].AA_options order by RECEIVED_DATETIME desc

;With cte1 AS(
select 
 --F1.id,
f1.Layout,
O.splitdata 
 from
(
select *,
cast('<X>'+replace(F.Layout,'_','</X><X>')+'</X>' as XML) as xmlfilter
from @t F
)F1
cross apply
( 
 select fdata.D.value('.','varchar(MAX)') as splitdata 
 from f1.xmlfilter.nodes('X') as fdata(D)) O
)
select ROW_NUMBER() OVER(ORDER BY (SELECT NULL)) as ID,splitdata,Layout
into #temp from cte1

select splitdata from 
(select *, 
DENSE_RANK() 
   OVER (PARTITION BY layout ORDER BY ID) Drank 
 from #temp) T where T.Drank = 3

drop table #temp
