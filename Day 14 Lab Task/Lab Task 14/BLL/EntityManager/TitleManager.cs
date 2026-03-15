using BLL.Entities;
using BLL.EntityList;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace BLL.EntityManager
{
    public static class TitleManager
    {
        static DBManager Manager = new();

        public static TitleList SelectALLTitles()
        {
            try
            {
                return DataTableToTitleList(Manager.ExecuteDataTable("sp_getalltitles"));
            }
            catch
            {

            }
            return new();
        }

        public static int UpdateTitles(TitleList titleList)
        {
            int affectedRows = 0;
            try
            {
                foreach (Title title in titleList)
                {
                    

                    switch (title.entityState)
                    {
                        case EntityState.Modified:
                            Dictionary<string, object> updateParams = new()
                            {
                                ["@TitleId"] = title.TitleId,
                                ["@TitleName"] = title.TitleName
                            };
                            if (Manager.ExecuteNonQuery("sp_UpdateTitle", updateParams) > 0)
                            {
                                affectedRows++;
                            }
                            break;

                        case EntityState.Added:
                            Dictionary<string, object> insertParams = new()
                            {
                                ["@TitleId"] = title.TitleId,
                                ["@TitleName"] = title.TitleName,
                                ["@Type"] = title.Type,
                            };
                            if (Manager.ExecuteNonQuery("sp_InsertTitle", insertParams) > 0)
                            {
                                affectedRows++;
                            }
                            break;

                        case EntityState.Deleted:
                            Dictionary<string, object> deleteParams = new()
                            {
                                ["@TitleId"] = title.TitleId
                            };
                            if (Manager.ExecuteNonQuery("sp_DeleteTitle", deleteParams) > 0)
                                affectedRows++;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return affectedRows;
        }

        internal static TitleList DataTableToTitleList(DataTable dt)
        {
            TitleList Prds = new TitleList();
            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    Prds.Add(DataRowToTitle(item));
                }
            }
            catch
            {

            }
            return Prds;
        }

        internal static Title DataRowToTitle(DataRow Dr)
        {
            Title P = new() { TitleName = String.Empty };
            try
            {
                P.TitleId = Dr.Field<string>("title_id");
                P.TitleName = Dr["title"]?.ToString() ?? "NA";
                P.Type = Dr.Field<string?>("type");
                P.PubId = Dr.Field<string?>("pub_id");
                P.Price = Dr.Field<decimal?>("price");
                P.Advance = Dr.Field<decimal?>("advance");
                P.Royalty = Dr.Field<int?>("royalty");
                P.YtdSales = Dr.Field<int?>("ytd_sales");
                P.Notes = Dr.Field<string?>("notes");
                P.PubDate = Dr.Field<DateTime>("pubdate");
                P.entityState = EntityState.UnChanged;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return P;
        }
    }

}
