CREATE TABLE `people` (
  `id` int(6) unsigned NOT NULL,
  `fio` varchar(200) NOT NULL,
  `bday` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) DEFAULT CHARSET=utf8;
INSERT INTO `people` (`id`, `fio`, `bday`, `status`) VALUES
('1',	'Иванов И. И.','12.02.1990',	'женат'),
('2',	'Иванов И. И.','18.09.2001',	'холост'),
('3',	'Петров П. П.','23.04.1983',	'женат'),
('4',	'Васильев В. В.','21.05.1998',	'холост'),
('25',	'Кузьмин К.К.','21.05.2020',	'холост');

CREATE TABLE `address` (
  `id` int(6) unsigned NOT NULL,
  `address` varchar(200) NOT NULL,
  `comment` varchar(200) NOT NULL
) DEFAULT CHARSET=utf8;
INSERT INTO `address` (`id`, `address`, `comment`) VALUES
('1',	'Можга',	'Место рождения'),
('1',	'Казань',	'По прописке'),
('1',	'Москва',	'Рабочий'),
('2',	'СанктПетербург',	'По прописке'),
('3',	'Москва',	'По прописке'),
('4',	'Белгород',	'По прописке'),
('5',	'Уфа',	'По прописке'),
('6',	'Сочи',	'По прописке'),
('7',	'Киров',	'Рабочий'),
('8',	'Владивосток',	'Место рождения'),
('9',	'Рязань',	'Рабочий'),
('10',	'Хабаровск',	'Место рождения');


select * from people p inner join address a on p.id = a.id
select * from people p left join address a on p.id = a.id
select * from people p right join address a on p.id = a.id
select * from people p left join address a on p.id = a.id union select * from people p right join address a on p.id = a.id