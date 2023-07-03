using Contracts.ScheduledJobs;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ScheduledJobs
{
    public class HangfireService : IScheduledJobService
    {
        //Chạy một Job
        public string Enqueue(Expression<Action> functionCall)
            => BackgroundJob.Enqueue(functionCall);

        public string Enqueue<T>(Expression<Action<T>> functionCall)
            => BackgroundJob.Enqueue<T>(functionCall);

        // Chạy 1 jon sau 1 khoamngr delay hoặc 1 thời điểm cụ thể
        public string Schedule(Expression<Action> functionCall, TimeSpan delay)
            => BackgroundJob.Schedule(functionCall, delay);

        public string Schedule<T>(Expression<Action<T>> functionCall, TimeSpan delay)
            => BackgroundJob.Schedule<T>(functionCall, delay);

        public string Schedule(Expression<Action> functionCall, DateTimeOffset enqueueAt)
            => BackgroundJob.Schedule(functionCall, enqueueAt);

        //Tiếp tục chạy sau khi 1 cv hoàn thành
        public string ContinueQueueWith(string parentJobId, Expression<Action> functionCall)
            => BackgroundJob.ContinueJobWith(parentJobId, functionCall);

        public bool Delete(string jobId) => BackgroundJob.Delete(jobId);

        //Đưa 1 cv đã faild vào hàng đợi
        public bool Requeue(string jobId) => BackgroundJob.Requeue(jobId);
    }
}
