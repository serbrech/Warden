﻿using System;

using Warden.Core;

namespace Warden.Watchers.MsSql
{
    /// <summary>
    /// Custom extension methods for the MSSQL watcher.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Extension method for adding the MSSQL watcher to the the WardenConfiguration with the default name of MSSQL Watcher.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="connectionString">Connection string of the MSSQL database.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMsSqlWatcher(
            this WardenConfiguration.Builder builder, string connectionString,
            Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MsSqlWatcher.Create(connectionString), hooks);

            return builder;
        }

        /// <summary>
        /// Extension method for adding the MSSQL watcher to the the WardenConfiguration.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="name">Name of the MsSqlWatcher.</param>
        /// <param name="connectionString">Connection string of the MSSQL database.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMsSqlWatcher(
            this WardenConfiguration.Builder builder, string name, string connectionString,
            Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MsSqlWatcher.Create(connectionString), hooks);

            return builder;
        }

        /// <summary>
        /// Extension method for adding the MSSQL watcher to the the WardenConfiguration with the default name of MSSQL Watcher.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="connectionString">Connection string of the MSSQL database.</param>
        /// <param name="configurator">Lambda expression for configuring the MsSqlWatcher.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        public static WardenConfiguration.Builder AddMsSqlWatcher(
            this WardenConfiguration.Builder builder, string connectionString,
            Action<MsSqlWatcherConfiguration.Default> configurator,
            Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MsSqlWatcher.Create(connectionString, configurator), hooks);

            return builder;
        }

        /// <summary>
        /// Extension method for adding the MSSQL watcher to the the WardenConfiguration.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="name">Name of the MsSqlWatcher.</param>
        /// <param name="connectionString">Connection string of the MSSQL database.</param>
        /// <param name="configurator">Lambda expression for configuring the MsSqlWatcher.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMsSqlWatcher(
            this WardenConfiguration.Builder builder, string name, string connectionString,
            Action<MsSqlWatcherConfiguration.Default> configurator,
            Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MsSqlWatcher.Create(name, connectionString, configurator), hooks);

            return builder;
        }


        /// <summary>
        /// Extension method for adding the MSSQL watcher to the the WardenConfiguration with the default name of MSSQL Watcher.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="configuration">Configuration of MsSqlWatcher.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMsSqlWatcher(
            this WardenConfiguration.Builder builder,
            MsSqlWatcherConfiguration configuration,
            Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MsSqlWatcher.Create(configuration), hooks);

            return builder;
        }

        /// <summary>
        /// Extension method for adding the MSSQL watcher to the the WardenConfiguration.
        /// </summary>
        /// <param name="builder">Instance of the Warden configuration builder.</param>
        /// <param name="name">Name of the MsSqlWatcher.</param>
        /// <param name="configuration">Configuration of MsSqlWatcher.</param>
        /// <param name="hooks">Optional lambda expression for configuring the watcher hooks.</param>
        /// <returns>Instance of fluent builder for the WardenConfiguration.</returns>
        public static WardenConfiguration.Builder AddMsSqlWatcher(
            this WardenConfiguration.Builder builder, string name,
            MsSqlWatcherConfiguration configuration,
            Action<WatcherHooksConfiguration.Builder> hooks = null)
        {
            builder.AddWatcher(MsSqlWatcher.Create(name, configuration), hooks);

            return builder;
        }
    }
}