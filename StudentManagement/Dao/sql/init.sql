CREATE DATABASE `studentmanagement` CHARACTER SET 'utf8' COLLATE 'utf8_bin';

use studentmanagement;
CREATE TABLE `studentmanagement`.`t_student`  (
  `id` int(0) NOT NULL AUTO_INCREMENT COMMENT '主键，自动自增，唯一id',
  `name` varchar(20) NOT NULL COMMENT '姓名',
  `age` int(0) NULL COMMENT '年龄',
  `sex` int(0) NULL COMMENT '性别',
  `birthday` date NULL COMMENT '生日',
  PRIMARY KEY (`id`)
);