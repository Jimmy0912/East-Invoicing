### <a name="1"> 供应商管理（tbSupplier）tbSupplier </a>

|字段名|类型|是否为空|默认值|描述|值说明|
|:---:|:---:|:---:|:---:|:---:|:---:|
|mid|Int(11)|否|无|主键|
|code|varchar(100)|是|无|供应商编号||
|name|varchar(100)|是|无|供应商名称||
|contact|varchar(100)|是|无|联系人||
|tel|varchar(100)|是|无|联系电话||
|address|varchar(100)|是|无|联系地址||
|inday|datetime|否|无|创建时间|
|upday|datetime|否|无|修改时间|


```sql
DROP TABLE IF EXISTS `tbSupplier`;
CREATE TABLE  tbSupplier(
`mid`     	varchar(40)    		NOT NULL   	,
`code`     	varchar(40)    		NOT NULL   	,
`name`     	varchar(40)    		NOT NULL   	,
`contact`     	varchar(40)    		NOT NULL   	,
`tel`     	varchar(40)    		NOT NULL   	,
`inday` 	datetime        NOT NULL 	,
`upday` 	datetime        NOT NULL   	,
PRIMARY KEY (`mid`) USING BTREE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```
