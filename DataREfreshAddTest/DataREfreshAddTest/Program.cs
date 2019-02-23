﻿using System;
using System.Data;
using System.Data.OleDb;
//using System.Data.OracleClient;
//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApplication9
{
    class CommandExam
    {
        public static void Main()
        {
            string str = @"Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
 (CONNECT_DATA =(SERVER = DEDICATED)
(SERVICE_NAME = topcredu)
 )
 ); User Id = scott; Password = tiger";
            OracleConnection Conn = new OracleConnection(str);
            Conn.Open();
            //갱신 및 기타 작업을 위한 Adapter 를 하나 만든다.
            OracleDataAdapter adapter = new OracleDataAdapter("select * from emp", Conn);
            DataSet ds = new DataSet("myemp");
            adapter.Fill(ds, "사원");
            //가지고 온 자료를 화면에 뿌리자...
            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"],
                r["ename"], r["sal"]);
            }
            //데이터를 변경 하자...
            ds.Tables["사원"].Rows[0]["ename"] = "홍길동";
            /*Update Method 를 호출 하기 위해 CommandBuilder 를 만들자.
            하나의 테이블을 갱신하는 간단한 경우 라면 변경용 Query 를 사용 할 필요가 없다.
            단지 자동적으로 적절핚 SQL 을 만들고 그것을 관련된 DataAdapter 에 연관 시키는
            CommandBuilder 개체를 사용하면 된다.
            CommandBuilder 에 DataAdapter 를 인자로
            주었는데 이렇게 하면 CommandBuilder 가 생성될때 생성자에 의해 적절핚
            SQL 명령문이 만들어지며 그것이 DataAdapter 에 연결 된다. */
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(adapter);
            /* Update 메소드는 DataTable 의 행들 중 변경된 데이터를 데이터베이스에
            적용한다. Rows 컬렉션안의 DataRow 개체에는 RowState 라는 속성이 있는데
            이 속성은 그 행의 삭제, 추가, 수정 여부 상태를 의미한다.
            */
            adapter.Update(ds, "사원");
            //변경 후 DataTable 자료 출력
            Console.WriteLine();
            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
              
            Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"],
            r["sal"]);
            }
            DataRow row = ds.Tables["사원"].NewRow();
            row["empno"] = 8988; row["ename"] = "87 길동"; row["sal"] = 7077;
            ds.Tables["사원"].Rows.Add(row);
            adapter.Update(ds, "사원");
            //다시 DB 에서 데이터 원본을 추출, 테이블의 내용이 바뀐 것을 확인하자.
            adapter = new OracleDataAdapter("select * from emp", Conn);
            adapter.Fill(ds, "사원");
            //추가 후 자료 출력
            Console.WriteLine();
            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"],
                r["sal"]);
            }
            Console.WriteLine(" 총 {0} 건 입니다.", ds.Tables["사원"].Rows.Count);
        }
    }
}