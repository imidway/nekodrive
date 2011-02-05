/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V3.RPC.Mount
{
    public class MountBody : XdrAble
    {
        private Name _hostname;
        private Name _directory;
        private MountList _nextentry;

        public MountBody()
        { }

        public MountBody(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            this._hostname.xdrEncode(xdr);
            this._directory.xdrEncode(xdr);
            this._nextentry.xdrEncode(xdr);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._hostname = new Name(xdr);
            this._directory = new Name(xdr);
            this._nextentry = new MountList(xdr);
        }

        public Name HostName
        {
            get
            { return this._hostname; }
        }

        public Name Directory
        {
            get
            { return this._directory; }
        }

        public MountList NextEntry
        {
            get
            { return this._nextentry; }
        }
    }
    // End of mountbody3.cs
}