﻿using System;

using Warden.Core;

namespace Warden.Watchers.MongoDb
{
    /// <summary>
    /// Custom extension methods for the MongoDB watcher.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Extension method for adding the MongoDB watcher to the the WardenConfiguration with the default name of MongoDB Watcher.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="connectionString">Connection string of the MongoDB database.</param>
        /// <param name="database">Name of the MongoDB database.</param>
        /// <param name="timeout">Optional timeout of the MongoDB query (5 seconds by default).</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMongoDbWatcher(
            this WardenConfiguration.Builder builder, string connectionString, string database, 
            TimeSpan? timeout = null, Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MongoDbWatcher.Create(connectionString, database, timeout), hooks);

            return builder;
        }

        /// <summary>
        /// Extension method for adding the MongoDB watcher to the the WardenConfiguration.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="name">Name of the MongoDbWatcher.</param>
        /// <param name="connectionString">Connection string of the MongoDB database.</param>
        /// <param name="database">Name of the MongoDB database.</param>
        /// <param name="timeout">Optional timeout of the MongoDB query (5 seconds by default).</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMongoDbWatcher(
            this WardenConfiguration.Builder builder, string name, 
            string connectionString, string database, TimeSpan? timeout = null,
            Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MongoDbWatcher.Create(name, connectionString, database, timeout), hooks);

            return builder;
        }

        /// <summary>
        /// Extension method for adding the MongoDB watcher to the the WardenConfiguration with the default name of MongoDB Watcher.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="connectionString">Connection string of the MongoDB database.</param>
        /// <param name="database">Name of the MongoDB database.</param>
        /// <param name="configurator">Lambda expression for configuring the MongoDbWatcher.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <param name="timeout">Optional timeout of the MongoDB query (5 seconds by default).</param>
        public static WardenConfiguration.Builder AddMongoDbWatcher(
            this WardenConfiguration.Builder builder,
            string connectionString, string database, 
            Action<MongoDbWatcherConfiguration.Default> configurator,
            Action<WatcherHooksConfiguration.Builder> hooks = null, TimeSpan? timeout = null)
        {
            builder.AddWatcher(MongoDbWatcher.Create(connectionString, database, timeout, configurator), hooks);

            return builder;
        }

        /// <summary>
        /// Extension method for adding the MongoDB watcher to the the WardenConfiguration.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="name">Name of the MongoDbWatcher.</param>
        /// <param name="connectionString">Connection string of the MongoDB database.</param>
        /// <param name="database">Name of the MongoDB database.</param>
        /// <param name="configurator">Lambda expression for configuring the MongoDbWatcher.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <param name="timeout">Optional timeout of the MongoDB query (5 seconds by default).</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMongoDbWatcher(
            this WardenConfiguration.Builder builder, string name,
            string connectionString, string database,
            Action<MongoDbWatcherConfiguration.Default> configurator,
            Action<WatcherHooksConfiguration.Builder> hooks = null, TimeSpan? timeout = null)
        {
            builder.AddWatcher(MongoDbWatcher.Create(name, connectionString, database, timeout, configurator), hooks);

            return builder;
        }

        /// <summary>
        /// Extension method for adding the MongoDB watcher to the the WardenConfiguration with the default name of MongoDB Watcher.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="configuration">Configuration of MongoDbWatcher.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMongoDbWatcher(
            this WardenConfiguration.Builder builder,
            MongoDbWatcherConfiguration configuration,
            Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MongoDbWatcher.Create(configuration), hooks);

            return builder;
        }

        /// <summary>
        /// Extension method for adding the MongoDB watcher to the the WardenConfiguration.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="name">Name of the MongoDbWatcher.</param>
        /// <param name="configuration">Configuration of MongoDbWatcher.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMongoDbWatcher(
            this WardenConfiguration.Builder builder, string name,
            MongoDbWatcherConfiguration configuration,
            Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MongoDbWatcher.Create(name, configuration), hooks);

            return builder;
        }
    }
}