using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthLibrary.Foundation.Foundation.Security
{
	public class ConfigReader : IConfiguration
	{
		public string this[string key]
		{
			get
			{
				return ConfigurationManager.AppSettings[key];
			}
			set => throw new NotImplementedException();
		}

		public IEnumerable<IConfigurationSection> GetChildren()
		{
			throw new NotImplementedException();
		}

		public IConfigurationSection GetSection(string key)
		{
			throw new NotImplementedException();
		}

		public IChangeToken GetReloadToken()
		{
			throw new NotImplementedException();
		}
	}
}
