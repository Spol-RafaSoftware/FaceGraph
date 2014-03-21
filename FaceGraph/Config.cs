namespace FaceGraph {
	/// <summary>
	/// Holds info about user and makes easy access to defined constants in resources
	/// </summary>
	static class Config {
		// @todo smazat muj token
		static public string ACCESS_TOKEN;
		static public string USER_ID, USER_NAME;

		static public string APP_ID {
			get {
				return FaceGraph.Properties.Resources.APP_ID;
			}
		}

		static public string APP_SECRET {
			get {
				return FaceGraph.Properties.Resources.APP_SECRET;
			}
		}

		static public string FACEBOOK_GRAPH {
			get {
				return FaceGraph.Properties.Resources.FACEBOOK_GRAPH;
			}
		}

		static public string FACEBOOK_LOGIN {
			get {
				return FaceGraph.Properties.Resources.FACEBOOK_LOGIN;
			}
		}

		static public string REDIRECT_URI {
			get {
				return FaceGraph.Properties.Resources.REDIRECT_SUCCESS;
			}
		}
	}
}
