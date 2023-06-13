create database itemBox_DB default character set utf8 collate utf8_general_ci;
use itemBox_DB;

create table host (
   room_id int not null auto_increment primary key,
    ip      varchar(15) not null,
    room_num int not null,
    curr_num int not null
) default character set utf8 collate utf8_general_ci;

create table game (
   qid int not null auto_increment primary key,
   question varchar(100) not null
) default character set utf8 collate utf8_general_ci;

alter table host auto_increment=1;
alter table game auto_increment=1;

INSERT INTO game(question) VALUES
('가지'), ('사자'), ('고구마'), ('주사기'), ('파도'), ('카드'), ('기타'), ('다리미'), ('차표'), ('허수아비'),
('주머니'), ('포도'), ('기차'), ('나비'), ('하마'), ('거미'), ('우비'), ('피아노'), ('타조'), ('바지'), ('바나나'),
('너구리'), ('부채'), ('피노키오'), ('모자'), ('매미'), ('마차'), ('라디오'), ('우유'), ('고래'), ('오리'),
('어머니'), ('누나'), ('마스크'), ('아기'), ('해바라기'), ('아버지'), ('오이'), ('고기'), ('자라');
