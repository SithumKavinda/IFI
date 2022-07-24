use [vidly];

drop table employee;
TRUNCATE TABLE employee;

drop table contact;
TRUNCATE TABLE contact;

drop table fund;
TRUNCATE TABLE fund;

drop table emp_fund;
TRUNCATE TABLE emp_fund;

drop table work_day;
TRUNCATE TABLE work_day;

drop table emp_work_day;
TRUNCATE TABLE emp_work_day;

drop table salary;
truncate table salary;

-- employee table
create table employee (
	nic varchar(12),
	fname varchar(100),
	lname varchar(100),
	house_no varchar(20),
	address varchar(100),
	city varchar(30),
	postal_code int,
	dob date,
	age int,
	gender char,
	joined_date date,
	payrate decimal(30, 2),	

	constraint employee_pk primary key (nic)
);

-- contact table
create table contact (
	nic varchar(12),
	phone varchar(10),
	contact_type varchar(20)

	constraint contact_fk foreign key(nic) references employee(nic)
);

-- fund table
create table fund (
	fund_id varchar(10),
	fund_name varchar(100),
	rate decimal(20, 2),

	constraint fund_pk primary key(fund_id)
);

-- emp_fund table
create table emp_fund (
	nic varchar(12),
	fund_id varchar(10),

	constraint emp_fund_fk_1 foreign key (nic) references employee(nic),
	constraint emp_fund_fk_2 foreign key (fund_id) references fund(fund_id)
);

-- workdays table
create table work_day (
	work_date date,
	is_sat int,
	is_sun int,
	is_holiday int,

	constraint work_day_pk primary key (work_date)
);

-- emp_workday
create table emp_work_day (
	nic varchar(12),
	work_date date,
	is_leave int,
	leave_type varchar(20),
	reason varchar(500),
	ot_hours decimal(10, 2),

	constraint emp_work_day_pk primary key (nic, work_date),
	constraint emp_work_day_fk_1 foreign key (nic) references employee(nic),
	constraint emp_work_day_fk_2 foreign key (work_date) references work_day(work_date)
);

-- salary table
create table salary (
	sal_id int identity(1,1),
	nic varchar(12),
	calc_date date,
	worked_days int,
	sat_count int,
	sun_count int,
	fund_deduction decimal(10, 2),
	ot_count decimal(10, 2),
	total decimal(30, 2),

	constraint salary_pk primary key (sal_id),
	constraint salary_fk foreign key (nic) references employee(nic)
);


USE [vidly]
GO

INSERT INTO [dbo].[employee] 
VALUES (
	'992993553v',
	'sithum',
	'kavinda',
	'58/40/a',
	'hiripitiya, pannipitiya',
	'kottawa',
	10232,
	'1999-10-25',
	23,
	'M',
	'2022-07-23',
	2000	
);

INSERT INTO [dbo].[employee] 
VALUES (
	'660313553v',
	'wasantha',
	'eshwarage',
	'58/40/a',
	'hiripitiya, pannipitiya',
	'kottawa',
	10232,
	'1966-01-31',
	55,
	'M',
	'2002-07-01',
	5000	
);

insert into [dbo].[contact]
values (
	'992993553v',
	'0719994659',
	'mobile'
);

insert into [dbo].[contact]
values (
	'992993553v',
	'0115629039',
	'home'
);

insert into [dbo].[contact]
values (
	'660313553v',
	'0710955293',
	'mobile'
);

insert into [dbo].[contact]
values (
	'660313553v',
	'0115629039',
	'home'
);
	

select * from [dbo].[employee];
select * from [dbo].[contact];