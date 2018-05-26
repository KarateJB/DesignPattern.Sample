from Factory_models import DbEnum, DbContext


class StcDbFactory(object):
    @staticmethod
    def create(dbEnum:DbEnum):
        
        return {
            DbEnum.DataMart: DbContext(server="DataMart", connectionStr="DataMart connection string"),
            DbEnum.History: DbContext(server="History", connectionStr="History connection string"),
            DbEnum.Online: DbContext(
                server="Online", connectionStr="Online connection string")
        }[dbEnum]

    @staticmethod
    def createDataMart():
        dbContext = DbContext(
            server="DataMart", connectionStr="DataMart connection string")
        return dbContext

    @staticmethod
    def createHistory():
        dbContext = DbContext(
            server="History", connectionStr="History connection string")
        return dbContext

    @staticmethod
    def createOnline():
        dbContext = DbContext(
            server="Online", connectionStr="Online connection string")
        return dbContext
