/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/19/2023 5:18:37 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_PUBLISH_AUTHOR')
alter table BOOK
   drop constraint FK_BOOK_PUBLISH_AUTHOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROWED_BOOKS') and o.name = 'FK_BORROWED_BORROWED_BOOK')
alter table BORROWED_BOOKS
   drop constraint FK_BORROWED_BORROWED_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"BROWSE"') and o.name = 'FK_BROWSE_BROWSE_STUDENT')
alter table "BROWSE"
   drop constraint FK_BROWSE_BROWSE_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"BROWSE"') and o.name = 'FK_BROWSE_BROWSE2_BOOK')
alter table "BROWSE"
   drop constraint FK_BROWSE_BROWSE2_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HELPS') and o.name = 'FK_HELPS_HELPS_SUPPORT')
alter table HELPS
   drop constraint FK_HELPS_HELPS_SUPPORT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HELPS') and o.name = 'FK_HELPS_HELPS2_STUDENT')
alter table HELPS
   drop constraint FK_HELPS_HELPS2_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANAGE') and o.name = 'FK_MANAGE_MANAGE_ADMIN')
alter table MANAGE
   drop constraint FK_MANAGE_MANAGE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MANAGE') and o.name = 'FK_MANAGE_MANAGE2_BOOK')
alter table MANAGE
   drop constraint FK_MANAGE_MANAGE2_BOOK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTHOR')
            and   type = 'U')
   drop table AUTHOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'PUBLISH_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.PUBLISH_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROWED_BOOKS')
            and   name  = 'BORROWED_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROWED_BOOKS.BORROWED_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BORROWED_BOOKS')
            and   type = 'U')
   drop table BORROWED_BOOKS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"BROWSE"')
            and   name  = 'BROWSE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index "BROWSE".BROWSE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"BROWSE"')
            and   name  = 'BROWSE_FK'
            and   indid > 0
            and   indid < 255)
   drop index "BROWSE".BROWSE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"BROWSE"')
            and   type = 'U')
   drop table "BROWSE"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HELPS')
            and   name  = 'HELPS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index HELPS.HELPS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HELPS')
            and   name  = 'HELPS_FK'
            and   indid > 0
            and   indid < 255)
   drop index HELPS.HELPS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HELPS')
            and   type = 'U')
   drop table HELPS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANAGE')
            and   name  = 'MANAGE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANAGE.MANAGE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MANAGE')
            and   name  = 'MANAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index MANAGE.MANAGE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MANAGE')
            and   type = 'U')
   drop table MANAGE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STUDENT')
            and   type = 'U')
   drop table STUDENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUPPORT')
            and   type = 'U')
   drop table SUPPORT
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMIN_ID             int                  not null,
   EMAIL                text                 null,
   PASSWORD             text                 null,
   constraint PK_ADMIN primary key (ADMIN_ID)
)
go

/*==============================================================*/
/* Table: AUTHOR                                                */
/*==============================================================*/
create table AUTHOR (
   AUTHOR_ID            int                  not null,
   AUTHOR_NAME          text                 null,
   constraint PK_AUTHOR primary key (AUTHOR_ID)
)
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   ISBN                 int                  not null,
   AUTHOR_ID            int                  null,
   BOOK_TITLE           text                 null,
   PUBLICATION_YEAR     datetime             null,
   constraint PK_BOOK primary key (ISBN)
)
go

/*==============================================================*/
/* Index: PUBLISH_FK                                            */
/*==============================================================*/




create nonclustered index PUBLISH_FK on BOOK (AUTHOR_ID ASC)
go

/*==============================================================*/
/* Table: BORROWED_BOOKS                                        */
/*==============================================================*/
create table BORROWED_BOOKS (
   BORROWED_DATE        datetime             not null,
   ISBN                 int                  null,
   RETURN_DATE          datetime             null,
   constraint PK_BORROWED_BOOKS primary key (BORROWED_DATE)
)
go

/*==============================================================*/
/* Index: BORROWED_FK                                           */
/*==============================================================*/




create nonclustered index BORROWED_FK on BORROWED_BOOKS (ISBN ASC)
go

/*==============================================================*/
/* Table: "BROWSE"                                              */
/*==============================================================*/
create table "BROWSE" (
   STUDENT_ID           int                  not null,
   ISBN                 int                  not null,
   constraint PK_BROWSE primary key (STUDENT_ID, ISBN)
)
go

/*==============================================================*/
/* Index: BROWSE_FK                                             */
/*==============================================================*/




create nonclustered index BROWSE_FK on "BROWSE" (STUDENT_ID ASC)
go

/*==============================================================*/
/* Index: BROWSE2_FK                                            */
/*==============================================================*/




create nonclustered index BROWSE2_FK on "BROWSE" (ISBN ASC)
go

/*==============================================================*/
/* Table: HELPS                                                 */
/*==============================================================*/
create table HELPS (
   SUPPORT_ID           int                  not null,
   STUDENT_ID           int                  not null,
   constraint PK_HELPS primary key (SUPPORT_ID, STUDENT_ID)
)
go

/*==============================================================*/
/* Index: HELPS_FK                                              */
/*==============================================================*/




create nonclustered index HELPS_FK on HELPS (SUPPORT_ID ASC)
go

/*==============================================================*/
/* Index: HELPS2_FK                                             */
/*==============================================================*/




create nonclustered index HELPS2_FK on HELPS (STUDENT_ID ASC)
go

/*==============================================================*/
/* Table: MANAGE                                                */
/*==============================================================*/
create table MANAGE (
   ADMIN_ID             int                  not null,
   ISBN                 int                  not null,
   constraint PK_MANAGE primary key (ADMIN_ID, ISBN)
)
go

/*==============================================================*/
/* Index: MANAGE_FK                                             */
/*==============================================================*/




create nonclustered index MANAGE_FK on MANAGE (ADMIN_ID ASC)
go

/*==============================================================*/
/* Index: MANAGE2_FK                                            */
/*==============================================================*/




create nonclustered index MANAGE2_FK on MANAGE (ISBN ASC)
go

/*==============================================================*/
/* Table: STUDENT                                               */
/*==============================================================*/
create table STUDENT (
   STUDENT_ID           int                  not null,
   EMAIL                text                 null,
   PASSWORD             text                 null,
   STUDENT_NAME         text                 null,
   constraint PK_STUDENT primary key (STUDENT_ID)
)
go

/*==============================================================*/
/* Table: SUPPORT                                               */
/*==============================================================*/
create table SUPPORT (
   SUPPORT_ID           int                  not null,
   EMAIL                text                 null,
   PASSWORD             text                 null,
   constraint PK_SUPPORT primary key (SUPPORT_ID)
)
go

alter table BOOK
   add constraint FK_BOOK_PUBLISH_AUTHOR foreign key (AUTHOR_ID)
      references AUTHOR (AUTHOR_ID)
go

alter table BORROWED_BOOKS
   add constraint FK_BORROWED_BORROWED_BOOK foreign key (ISBN)
      references BOOK (ISBN)
go

alter table "BROWSE"
   add constraint FK_BROWSE_BROWSE_STUDENT foreign key (STUDENT_ID)
      references STUDENT (STUDENT_ID)
go

alter table "BROWSE"
   add constraint FK_BROWSE_BROWSE2_BOOK foreign key (ISBN)
      references BOOK (ISBN)
go

alter table HELPS
   add constraint FK_HELPS_HELPS_SUPPORT foreign key (SUPPORT_ID)
      references SUPPORT (SUPPORT_ID)
go

alter table HELPS
   add constraint FK_HELPS_HELPS2_STUDENT foreign key (STUDENT_ID)
      references STUDENT (STUDENT_ID)
go

alter table MANAGE
   add constraint FK_MANAGE_MANAGE_ADMIN foreign key (ADMIN_ID)
      references ADMIN (ADMIN_ID)
go

alter table MANAGE
   add constraint FK_MANAGE_MANAGE2_BOOK foreign key (ISBN)
      references BOOK (ISBN)
go

