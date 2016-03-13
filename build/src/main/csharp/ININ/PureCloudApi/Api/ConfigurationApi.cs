using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigurationApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>string</returns>
        string DeleteDidpoolsDidpoolId (string didPoolId);
  
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteDidpoolsDidpoolIdWithHttpInfo (string didPoolId);
        
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>string</returns>
        string DeleteEdgesCertificateauthoritiesCertificateId (string certificateId);
  
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId);
        
        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string DeleteEdgesEdgeId (string edgeId);
  
        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgesEdgeIdWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns></returns>
        void DeleteEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId);
  
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string DeleteEdgesEdgeIdSoftwareupdate (string edgeId);
  
        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>string</returns>
        string DeleteEndpointsEndpointId (string endpointId);
  
        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteEndpointsEndpointIdWithHttpInfo (string endpointId);
        
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>string</returns>
        string DeleteExtensionpoolsExtensionpoolId (string extensionPoolId);
  
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId);
        
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>string</returns>
        string DeleteOrganizationsOrgId (string orgId);
  
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteOrganizationsOrgIdWithHttpInfo (string orgId);
        
        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>string</returns>
        string DeleteRetentionpolicies (string ids);
  
        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteRetentionpoliciesWithHttpInfo (string ids);
        
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>string</returns>
        string DeleteRetentionpoliciesPolicyId (string policyId);
  
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteRetentionpoliciesPolicyIdWithHttpInfo (string policyId);
        
        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>string</returns>
        string DeleteSitesSiteId (string siteId);
  
        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteSitesSiteIdWithHttpInfo (string siteId);
        
        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>DIDPoolEntityListing</returns>
        DIDPoolEntityListing GetDidpools (int? pageSize = null, int? pageNumber = null, string sortBy = null);
  
        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of DIDPoolEntityListing</returns>
        ApiResponse<DIDPoolEntityListing> GetDidpoolsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>DIDPool</returns>
        DIDPool GetDidpoolsDidpoolId (string didPoolId);
  
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> GetDidpoolsDidpoolIdWithHttpInfo (string didPoolId);
        
        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>DIDEntityListing</returns>
        DIDEntityListing GetDids (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);
  
        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>ApiResponse of DIDEntityListing</returns>
        ApiResponse<DIDEntityListing> GetDidsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);
        
        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>DID</returns>
        DID GetDidsDidId (string didId);
  
        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> GetDidsDidIdWithHttpInfo (string didId);
        
        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>EdgeEntityListing</returns>
        EdgeEntityListing GetEdges (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);
  
        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of EdgeEntityListing</returns>
        ApiResponse<EdgeEntityListing> GetEdgesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);
        
        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CertificateAuthorityEntityListing</returns>
        CertificateAuthorityEntityListing GetEdgesCertificateauthorities ();
  
        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CertificateAuthorityEntityListing</returns>
        ApiResponse<CertificateAuthorityEntityListing> GetEdgesCertificateauthoritiesWithHttpInfo ();
        
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority GetEdgesCertificateauthoritiesCertificateId (string certificateId);
  
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> GetEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId);
        
        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Edge</returns>
        Edge GetEdgesEdgeId (string edgeId);
  
        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> GetEdgesEdgeIdWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>EdgeLineEntityListing</returns>
        EdgeLineEntityListing GetEdgesEdgeIdLines (string edgeId, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of EdgeLineEntityListing</returns>
        ApiResponse<EdgeLineEntityListing> GetEdgesEdgeIdLinesWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>EdgeLine</returns>
        EdgeLine GetEdgesEdgeIdLinesLineId (string edgeId, string lineId);
  
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        ApiResponse<EdgeLine> GetEdgesEdgeIdLinesLineIdWithHttpInfo (string edgeId, string lineId);
        
        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>LogicalInterfaceEntityListing</returns>
        LogicalInterfaceEntityListing GetEdgesEdgeIdLogicalinterfaces (string edgeId);
  
        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of LogicalInterfaceEntityListing</returns>
        ApiResponse<LogicalInterfaceEntityListing> GetEdgesEdgeIdLogicalinterfacesWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface GetEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId);
  
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> GetEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>EdgeLogsJob</returns>
        EdgeLogsJob GetEdgesEdgeIdLogsJobsJobId (string edgeId, string jobId);
  
        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of EdgeLogsJob</returns>
        ApiResponse<EdgeLogsJob> GetEdgesEdgeIdLogsJobsJobIdWithHttpInfo (string edgeId, string jobId);
        
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>PhysicalInterfaceEntityListing</returns>
        PhysicalInterfaceEntityListing GetEdgesEdgeIdPhysicalinterfaces (string edgeId);
  
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of PhysicalInterfaceEntityListing</returns>
        ApiResponse<PhysicalInterfaceEntityListing> GetEdgesEdgeIdPhysicalinterfacesWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>DomainPhysicalInterface</returns>
        DomainPhysicalInterface GetEdgesEdgeIdPhysicalinterfacesInterfaceId (string edgeId, string interfaceId);
  
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        ApiResponse<DomainPhysicalInterface> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        DomainEdgeSoftwareUpdateDto GetEdgesEdgeIdSoftwareupdate (string edgeId);
  
        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        ApiResponse<DomainEdgeSoftwareUpdateDto> GetEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>DomainEdgeSoftwareVersionDto</returns>
        DomainEdgeSoftwareVersionDto GetEdgesEdgeIdSoftwareversions (string edgeId);
  
        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of DomainEdgeSoftwareVersionDto</returns>
        ApiResponse<DomainEdgeSoftwareVersionDto> GetEdgesEdgeIdSoftwareversionsWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EdgeVersionReport</returns>
        EdgeVersionReport GetEdgeversionreport ();
  
        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EdgeVersionReport</returns>
        ApiResponse<EdgeVersionReport> GetEdgeversionreportWithHttpInfo ();
        
        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>EndpointEntityListing</returns>
        EndpointEntityListing GetEndpoints (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
  
        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>ApiResponse of EndpointEntityListing</returns>
        ApiResponse<EndpointEntityListing> GetEndpointsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        
        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Endpoint</returns>
        Endpoint GetEndpointsEndpointId (string endpointId);
  
        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> GetEndpointsEndpointIdWithHttpInfo (string endpointId);
        
        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>ExtensionPoolEntityListing</returns>
        ExtensionPoolEntityListing GetExtensionpools (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);
  
        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>ApiResponse of ExtensionPoolEntityListing</returns>
        ApiResponse<ExtensionPoolEntityListing> GetExtensionpoolsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);
        
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ExtensionPool</returns>
        ExtensionPool GetExtensionpoolsExtensionpoolId (string extensionPoolId);
  
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> GetExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId);
        
        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>ExtensionEntityListing</returns>
        ExtensionEntityListing GetExtensions (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);
  
        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>ApiResponse of ExtensionEntityListing</returns>
        ApiResponse<ExtensionEntityListing> GetExtensionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);
        
        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Extension</returns>
        Extension GetExtensionsExtensionId (string extensionId);
  
        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> GetExtensionsExtensionIdWithHttpInfo (string extensionId);
        
        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Organization</returns>
        Organization GetOrganization ();
  
        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetOrganizationWithHttpInfo ();
        
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Organization</returns>
        Organization GetOrganizationsOrgId (string orgId);
  
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetOrganizationsOrgIdWithHttpInfo (string orgId);
        
        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>EncryptionKeyEntityListing</returns>
        EncryptionKeyEntityListing GetRecordingkeys (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        ApiResponse<EncryptionKeyEntityListing> GetRecordingkeysWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule GetRecordingkeysRotationschedule ();
  
        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> GetRecordingkeysRotationscheduleWithHttpInfo ();
        
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>PolicyEntityListing</returns>
        PolicyEntityListing GetRetentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
  
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        ApiResponse<PolicyEntityListing> GetRetentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
        
        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Policy</returns>
        Policy GetRetentionpoliciesPolicyId (string policyId);
  
        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> GetRetentionpoliciesPolicyIdWithHttpInfo (string policyId);
        
        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>SchemaCategoryEntityListing</returns>
        SchemaCategoryEntityListing GetSchemasEdgesVnext (int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of SchemaCategoryEntityListing</returns>
        ApiResponse<SchemaCategoryEntityListing> GetSchemasEdgesVnextWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>SchemaReferenceEntityListing</returns>
        SchemaReferenceEntityListing GetSchemasEdgesVnextSchemacategory (string schemaCategory, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        ApiResponse<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategoryWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>SchemaReferenceEntityListing</returns>
        SchemaReferenceEntityListing GetSchemasEdgesVnextSchemacategorySchematype (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
  
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        ApiResponse<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategorySchematypeWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Organization</returns>
        Organization GetSchemasEdgesVnextSchemacategorySchematypeSchemaId (string schemaCategory, string schemaType, string schemaId);
  
        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId);
        
        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Organization</returns>
        Organization GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
  
        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
        
        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>SiteEntityListing</returns>
        SiteEntityListing GetSites (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);
  
        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>ApiResponse of SiteEntityListing</returns>
        ApiResponse<SiteEntityListing> GetSitesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);
        
        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Site</returns>
        Site GetSitesSiteId (string siteId);
  
        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> GetSitesSiteIdWithHttpInfo (string siteId);
        
        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        List<NumberPlan> GetSitesSiteIdNumberplans (string siteId);
  
        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        ApiResponse<List<NumberPlan>> GetSitesSiteIdNumberplansWithHttpInfo (string siteId);
        
        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetSitesSiteIdNumberplansClassifications (string siteId, string classification = null);
  
        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> GetSitesSiteIdNumberplansClassificationsWithHttpInfo (string siteId, string classification = null);
        
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>NumberPlan</returns>
        NumberPlan GetSitesSiteIdNumberplansNumberplanId (string siteId, string numberPlanId);
  
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>ApiResponse of NumberPlan</returns>
        ApiResponse<NumberPlan> GetSitesSiteIdNumberplansNumberplanIdWithHttpInfo (string siteId, string numberPlanId);
        
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PatchRetentionpoliciesPolicyId (string policyId, Policy body = null);
  
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PatchRetentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null);
        
        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>DIDPool</returns>
        DIDPool PostDidpools (DIDPool body = null);
  
        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> PostDidpoolsWithHttpInfo (DIDPool body = null);
        
        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge</param>
        /// <returns>Edge</returns>
        Edge PostEdges (Edge body = null);
  
        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> PostEdgesWithHttpInfo (Edge body = null);
        
        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority PostEdgesCertificateauthorities (DomainCertificateAuthority body = null);
  
        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> PostEdgesCertificateauthoritiesWithHttpInfo (DomainCertificateAuthority body = null);
        
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface PostEdgesEdgeIdLogicalinterfaces (string edgeId, DomainLogicalInterface body = null);
  
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> PostEdgesEdgeIdLogicalinterfacesWithHttpInfo (string edgeId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>EdgeLogsJobResponse</returns>
        EdgeLogsJobResponse PostEdgesEdgeIdLogsJobs (string edgeId, EdgeLogsJobRequest body = null);
  
        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>ApiResponse of EdgeLogsJobResponse</returns>
        ApiResponse<EdgeLogsJobResponse> PostEdgesEdgeIdLogsJobsWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null);
        
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void PostEdgesEdgeIdLogsJobsJobIdUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);
  
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostEdgesEdgeIdLogsJobsJobIdUploadWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);
        
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>string</returns>
        string PostEdgesEdgeIdReboot (string edgeId);
  
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostEdgesEdgeIdRebootWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        DomainEdgeSoftwareUpdateDto PostEdgesEdgeIdSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
  
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        ApiResponse<DomainEdgeSoftwareUpdateDto> PostEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
        
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>string</returns>
        string PostEdgesEdgeIdUnpair (string edgeId);
  
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostEdgesEdgeIdUnpairWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Endpoint</returns>
        Endpoint PostEndpoints (Endpoint body = null);
  
        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> PostEndpointsWithHttpInfo (Endpoint body = null);
        
        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Extension</returns>
        Extension PostExtensionpools (ExtensionPool body = null);
  
        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> PostExtensionpoolsWithHttpInfo (ExtensionPool body = null);
        
        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Organization</returns>
        Organization PostOrganizations (OrganizationCreate body = null);
  
        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> PostOrganizationsWithHttpInfo (OrganizationCreate body = null);
        
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EncryptionKey</returns>
        EncryptionKey PostRecordingkeys ();
  
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EncryptionKey</returns>
        ApiResponse<EncryptionKey> PostRecordingkeysWithHttpInfo ();
        
        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PostRetentionpolicies (Policy body = null);
  
        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PostRetentionpoliciesWithHttpInfo (Policy body = null);
        
        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site</param>
        /// <returns>Site</returns>
        Site PostSites (Site body = null);
  
        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> PostSitesWithHttpInfo (Site body = null);
        
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns></returns>
        void PostSitesSiteIdRebalance (string siteId);
  
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostSitesSiteIdRebalanceWithHttpInfo (string siteId);
        
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>DIDPool</returns>
        DIDPool PutDidpoolsDidpoolId (string didPoolId, DIDPool body = null);
  
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DIDPool</returns>
        ApiResponse<DIDPool> PutDidpoolsDidpoolIdWithHttpInfo (string didPoolId, DIDPool body = null);
        
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>DID</returns>
        DID PutDidsDidId (string didId, DID body = null);
  
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DID</returns>
        ApiResponse<DID> PutDidsDidIdWithHttpInfo (string didId, DID body = null);
        
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>DomainCertificateAuthority</returns>
        DomainCertificateAuthority PutEdgesCertificateauthoritiesCertificateId (string certificateId, DomainCertificateAuthority body = null);
  
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        ApiResponse<DomainCertificateAuthority> PutEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);
        
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Edge</returns>
        Edge PutEdgesEdgeId (string edgeId, Edge body = null);
  
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>ApiResponse of Edge</returns>
        ApiResponse<Edge> PutEdgesEdgeIdWithHttpInfo (string edgeId, Edge body = null);
        
        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>EdgeLine</returns>
        EdgeLine PutEdgesEdgeIdLinesLineId (string edgeId, string lineId, EdgeLine body = null);
  
        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>ApiResponse of EdgeLine</returns>
        ApiResponse<EdgeLine> PutEdgesEdgeIdLinesLineIdWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);
        
        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>DomainLogicalInterface</returns>
        DomainLogicalInterface PutEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId, DomainLogicalInterface body = null);
  
        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        ApiResponse<DomainLogicalInterface> PutEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Endpoint</returns>
        Endpoint PutEndpointsEndpointId (string endpointId, Endpoint body = null);
  
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>ApiResponse of Endpoint</returns>
        ApiResponse<Endpoint> PutEndpointsEndpointIdWithHttpInfo (string endpointId, Endpoint body = null);
        
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ExtensionPool</returns>
        ExtensionPool PutExtensionpoolsExtensionpoolId (string extensionPoolId, ExtensionPool body = null);
  
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>ApiResponse of ExtensionPool</returns>
        ApiResponse<ExtensionPool> PutExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId, ExtensionPool body = null);
        
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Extension</returns>
        Extension PutExtensionsExtensionId (string extensionId, Extension body = null);
  
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Extension</returns>
        ApiResponse<Extension> PutExtensionsExtensionIdWithHttpInfo (string extensionId, Extension body = null);
        
        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Organization</returns>
        Organization PutOrganization (Organization body = null);
  
        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> PutOrganizationWithHttpInfo (Organization body = null);
        
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Organization</returns>
        Organization PutOrganizationsOrgId (string orgId, Organization body = null);
  
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>ApiResponse of Organization</returns>
        ApiResponse<Organization> PutOrganizationsOrgIdWithHttpInfo (string orgId, Organization body = null);
        
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule PutRecordingkeysRotationschedule (KeyRotationSchedule body = null);
  
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> PutRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body = null);
        
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PutRetentionpoliciesPolicyId (string policyId, Policy body = null);
  
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PutRetentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null);
        
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Site</returns>
        Site PutSitesSiteId (string siteId, Site body = null);
  
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>ApiResponse of Site</returns>
        ApiResponse<Site> PutSitesSiteIdWithHttpInfo (string siteId, Site body = null);
        
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>List&lt;NumberPlan&gt;</returns>
        List<NumberPlan> PutSitesSiteIdNumberplans (string siteId, List<NumberPlan> body = null);
  
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        ApiResponse<List<NumberPlan>> PutSitesSiteIdNumberplansWithHttpInfo (string siteId, List<NumberPlan> body = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteDidpoolsDidpoolIdAsync (string didPoolId);

        /// <summary>
        /// Delete a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId);
        
        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgesCertificateauthoritiesCertificateIdAsync (string certificateId);

        /// <summary>
        /// Delete a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId);
        
        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgesEdgeIdAsync (string edgeId);

        /// <summary>
        /// Delete a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesEdgeIdAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Delete an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEdgesEdgeIdSoftwareupdateAsync (string edgeId);

        /// <summary>
        /// Cancels any in-progress update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteEndpointsEndpointIdAsync (string endpointId);

        /// <summary>
        /// Delete endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteEndpointsEndpointIdAsyncWithHttpInfo (string endpointId);
        
        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteExtensionpoolsExtensionpoolIdAsync (string extensionPoolId);

        /// <summary>
        /// Delete an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId);
        
        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteOrganizationsOrgIdAsync (string orgId);

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteOrganizationsOrgIdAsyncWithHttpInfo (string orgId);
        
        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteRetentionpoliciesAsync (string ids);

        /// <summary>
        /// Delete policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesAsyncWithHttpInfo (string ids);
        
        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteRetentionpoliciesPolicyIdAsync (string policyId);

        /// <summary>
        /// Delete policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteSitesSiteIdAsync (string siteId);

        /// <summary>
        /// Delete an ednpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteSitesSiteIdAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of DIDPoolEntityListing</returns>
        System.Threading.Tasks.Task<DIDPoolEntityListing> GetDidpoolsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null);

        /// <summary>
        /// Get a listing of DID Pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (DIDPoolEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPoolEntityListing>> GetDidpoolsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null);
        
        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> GetDidpoolsDidpoolIdAsync (string didPoolId);

        /// <summary>
        /// Get a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> GetDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId);
        
        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>Task of DIDEntityListing</returns>
        System.Threading.Tasks.Task<DIDEntityListing> GetDidsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);

        /// <summary>
        /// Get a listing of DIDs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>Task of ApiResponse (DIDEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDEntityListing>> GetDidsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null);
        
        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> GetDidsDidIdAsync (string didId);

        /// <summary>
        /// Get a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> GetDidsDidIdAsyncWithHttpInfo (string didId);
        
        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EdgeEntityListing</returns>
        System.Threading.Tasks.Task<EdgeEntityListing> GetEdgesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);

        /// <summary>
        /// Get the list of edges.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EdgeEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeEntityListing>> GetEdgesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null);
        
        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CertificateAuthorityEntityListing</returns>
        System.Threading.Tasks.Task<CertificateAuthorityEntityListing> GetEdgesCertificateauthoritiesAsync ();

        /// <summary>
        /// Get the list of certificate authorities.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CertificateAuthorityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CertificateAuthorityEntityListing>> GetEdgesCertificateauthoritiesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> GetEdgesCertificateauthoritiesCertificateIdAsync (string certificateId);

        /// <summary>
        /// Get a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> GetEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId);
        
        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> GetEdgesEdgeIdAsync (string edgeId);

        /// <summary>
        /// Get edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> GetEdgesEdgeIdAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EdgeLineEntityListing</returns>
        System.Threading.Tasks.Task<EdgeLineEntityListing> GetEdgesEdgeIdLinesAsync (string edgeId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get the list of lines.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EdgeLineEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLineEntityListing>> GetEdgesEdgeIdLinesAsyncWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of EdgeLine</returns>
        System.Threading.Tasks.Task<EdgeLine> GetEdgesEdgeIdLinesLineIdAsync (string edgeId, string lineId);

        /// <summary>
        /// Get line
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> GetEdgesEdgeIdLinesLineIdAsyncWithHttpInfo (string edgeId, string lineId);
        
        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of LogicalInterfaceEntityListing</returns>
        System.Threading.Tasks.Task<LogicalInterfaceEntityListing> GetEdgesEdgeIdLogicalinterfacesAsync (string edgeId);

        /// <summary>
        /// Get edge logical interfaces.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all configured logical interfaces from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (LogicalInterfaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LogicalInterfaceEntityListing>> GetEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get an edge logical interface
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of EdgeLogsJob</returns>
        System.Threading.Tasks.Task<EdgeLogsJob> GetEdgesEdgeIdLogsJobsJobIdAsync (string edgeId, string jobId);

        /// <summary>
        /// Get an Edge logs job.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (EdgeLogsJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLogsJob>> GetEdgesEdgeIdLogsJobsJobIdAsyncWithHttpInfo (string edgeId, string jobId);
        
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of PhysicalInterfaceEntityListing</returns>
        System.Threading.Tasks.Task<PhysicalInterfaceEntityListing> GetEdgesEdgeIdPhysicalinterfacesAsync (string edgeId);

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (PhysicalInterfaceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhysicalInterfaceEntityListing>> GetEdgesEdgeIdPhysicalinterfacesAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainPhysicalInterface</returns>
        System.Threading.Tasks.Task<DomainPhysicalInterface> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId);

        /// <summary>
        /// Get edge physical interface.
        /// </summary>
        /// <remarks>
        /// Retrieve a physical interface from a specific edge.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId);
        
        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> GetEdgesEdgeIdSoftwareupdateAsync (string edgeId);

        /// <summary>
        /// Gets software update status information about any edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> GetEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareVersionDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareVersionDto> GetEdgesEdgeIdSoftwareversionsAsync (string edgeId);

        /// <summary>
        /// Gets all the available software versions for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareVersionDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareVersionDto>> GetEdgesEdgeIdSoftwareversionsAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EdgeVersionReport</returns>
        System.Threading.Tasks.Task<EdgeVersionReport> GetEdgeversionreportAsync ();

        /// <summary>
        /// Get the edge version report.
        /// </summary>
        /// <remarks>
        /// The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EdgeVersionReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeVersionReport>> GetEdgeversionreportAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EndpointEntityListing</returns>
        System.Threading.Tasks.Task<EndpointEntityListing> GetEndpointsAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);

        /// <summary>
        /// Get endpoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EndpointEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EndpointEntityListing>> GetEndpointsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null);
        
        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> GetEndpointsEndpointIdAsync (string endpointId);

        /// <summary>
        /// Get endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> GetEndpointsEndpointIdAsyncWithHttpInfo (string endpointId);
        
        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>Task of ExtensionPoolEntityListing</returns>
        System.Threading.Tasks.Task<ExtensionPoolEntityListing> GetExtensionpoolsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);

        /// <summary>
        /// Get a listing of extension pools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>Task of ApiResponse (ExtensionPoolEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPoolEntityListing>> GetExtensionpoolsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null);
        
        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> GetExtensionpoolsExtensionpoolIdAsync (string extensionPoolId);

        /// <summary>
        /// Get an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> GetExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId);
        
        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>Task of ExtensionEntityListing</returns>
        System.Threading.Tasks.Task<ExtensionEntityListing> GetExtensionsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);

        /// <summary>
        /// Get a listing of extensions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>Task of ApiResponse (ExtensionEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionEntityListing>> GetExtensionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null);
        
        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> GetExtensionsExtensionIdAsync (string extensionId);

        /// <summary>
        /// Get an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> GetExtensionsExtensionIdAsyncWithHttpInfo (string extensionId);
        
        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetOrganizationAsync ();

        /// <summary>
        /// Get context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetOrganizationsOrgIdAsync (string orgId);

        /// <summary>
        /// Get organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationsOrgIdAsyncWithHttpInfo (string orgId);
        
        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        System.Threading.Tasks.Task<EncryptionKeyEntityListing> GetRecordingkeysAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> GetRecordingkeysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> GetRecordingkeysRotationscheduleAsync ();

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> GetRecordingkeysRotationscheduleAsyncWithHttpInfo ();
        
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>Task of PolicyEntityListing</returns>
        System.Threading.Tasks.Task<PolicyEntityListing> GetRetentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary=true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetRetentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
        
        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> GetRetentionpoliciesPolicyIdAsync (string policyId);

        /// <summary>
        /// Get policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> GetRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId);
        
        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaCategoryEntityListing</returns>
        System.Threading.Tasks.Task<SchemaCategoryEntityListing> GetSchemasEdgesVnextAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Lists available schema categories
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaCategoryEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaCategoryEntityListing>> GetSchemasEdgesVnextAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategoryAsync (string schemaCategory, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemacategoryAsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategorySchematypeAsync (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// List schemas of a specific category
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemacategorySchematypeAsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null);
        
        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsync (string schemaCategory, string schemaType, string schemaId);

        /// <summary>
        /// Get a json schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId);
        
        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsync (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);

        /// <summary>
        /// Get metadata for a schema
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null);
        
        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>Task of SiteEntityListing</returns>
        System.Threading.Tasks.Task<SiteEntityListing> GetSitesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);

        /// <summary>
        /// Get the list of sites.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>Task of ApiResponse (SiteEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<SiteEntityListing>> GetSitesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null);
        
        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> GetSitesSiteIdAsync (string siteId);

        /// <summary>
        /// Get endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> GetSitesSiteIdAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        System.Threading.Tasks.Task<List<NumberPlan>> GetSitesSiteIdNumberplansAsync (string siteId);

        /// <summary>
        /// Get the list of Number Plans for this Site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> GetSitesSiteIdNumberplansAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> GetSitesSiteIdNumberplansClassificationsAsync (string siteId, string classification = null);

        /// <summary>
        /// Get a list of Classifications for this Site
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> GetSitesSiteIdNumberplansClassificationsAsyncWithHttpInfo (string siteId, string classification = null);
        
        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of NumberPlan</returns>
        System.Threading.Tasks.Task<NumberPlan> GetSitesSiteIdNumberplansNumberplanIdAsync (string siteId, string numberPlanId);

        /// <summary>
        /// Get a Number Plan by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        System.Threading.Tasks.Task<ApiResponse<NumberPlan>> GetSitesSiteIdNumberplansNumberplanIdAsyncWithHttpInfo (string siteId, string numberPlanId);
        
        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PatchRetentionpoliciesPolicyIdAsync (string policyId, Policy body = null);

        /// <summary>
        /// Patch a retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null);
        
        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> PostDidpoolsAsync (DIDPool body = null);

        /// <summary>
        /// Create a new DID pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> PostDidpoolsAsyncWithHttpInfo (DIDPool body = null);
        
        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> PostEdgesAsync (Edge body = null);

        /// <summary>
        /// Create a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> PostEdgesAsyncWithHttpInfo (Edge body = null);
        
        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> PostEdgesCertificateauthoritiesAsync (DomainCertificateAuthority body = null);

        /// <summary>
        /// Create a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PostEdgesCertificateauthoritiesAsyncWithHttpInfo (DomainCertificateAuthority body = null);
        
        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> PostEdgesEdgeIdLogicalinterfacesAsync (string edgeId, DomainLogicalInterface body = null);

        /// <summary>
        /// Create an edge logical interface.
        /// </summary>
        /// <remarks>
        /// Create
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PostEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of EdgeLogsJobResponse</returns>
        System.Threading.Tasks.Task<EdgeLogsJobResponse> PostEdgesEdgeIdLogsJobsAsync (string edgeId, EdgeLogsJobRequest body = null);

        /// <summary>
        /// Create a job to upload a list of Edge logs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of ApiResponse (EdgeLogsJobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLogsJobResponse>> PostEdgesEdgeIdLogsJobsAsyncWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null);
        
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostEdgesEdgeIdLogsJobsJobIdUploadAsync (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostEdgesEdgeIdLogsJobsJobIdUploadAsyncWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null);
        
        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostEdgesEdgeIdRebootAsync (string edgeId);

        /// <summary>
        /// Reboot an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostEdgesEdgeIdRebootAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> PostEdgesEdgeIdSoftwareupdateAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null);

        /// <summary>
        /// Starts a software update for this edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> PostEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null);
        
        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostEdgesEdgeIdUnpairAsync (string edgeId);

        /// <summary>
        /// Unpair an Edge
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostEdgesEdgeIdUnpairAsyncWithHttpInfo (string edgeId);
        
        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> PostEndpointsAsync (Endpoint body = null);

        /// <summary>
        /// Create endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> PostEndpointsAsyncWithHttpInfo (Endpoint body = null);
        
        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> PostExtensionpoolsAsync (ExtensionPool body = null);

        /// <summary>
        /// Create a new extension pool
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> PostExtensionpoolsAsyncWithHttpInfo (ExtensionPool body = null);
        
        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> PostOrganizationsAsync (OrganizationCreate body = null);

        /// <summary>
        /// Create organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> PostOrganizationsAsyncWithHttpInfo (OrganizationCreate body = null);
        
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EncryptionKey</returns>
        System.Threading.Tasks.Task<EncryptionKey> PostRecordingkeysAsync ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingkeysAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PostRetentionpoliciesAsync (Policy body = null);

        /// <summary>
        /// Create retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PostRetentionpoliciesAsyncWithHttpInfo (Policy body = null);
        
        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> PostSitesAsync (Site body = null);

        /// <summary>
        /// Create a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> PostSitesAsyncWithHttpInfo (Site body = null);
        
        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostSitesSiteIdRebalanceAsync (string siteId);

        /// <summary>
        /// Triggers the rebalance operation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostSitesSiteIdRebalanceAsyncWithHttpInfo (string siteId);
        
        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        System.Threading.Tasks.Task<DIDPool> PutDidpoolsDidpoolIdAsync (string didPoolId, DIDPool body = null);

        /// <summary>
        /// Update a DID Pool by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<DIDPool>> PutDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId, DIDPool body = null);
        
        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DID</returns>
        System.Threading.Tasks.Task<DID> PutDidsDidIdAsync (string didId, DID body = null);

        /// <summary>
        /// Update a DID by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DID)</returns>
        System.Threading.Tasks.Task<ApiResponse<DID>> PutDidsDidIdAsyncWithHttpInfo (string didId, DID body = null);
        
        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        System.Threading.Tasks.Task<DomainCertificateAuthority> PutEdgesCertificateauthoritiesCertificateIdAsync (string certificateId, DomainCertificateAuthority body = null);

        /// <summary>
        /// Update a certificate authority.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PutEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null);
        
        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        System.Threading.Tasks.Task<Edge> PutEdgesEdgeIdAsync (string edgeId, Edge body = null);

        /// <summary>
        /// Update a edge.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        System.Threading.Tasks.Task<ApiResponse<Edge>> PutEdgesEdgeIdAsyncWithHttpInfo (string edgeId, Edge body = null);
        
        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of EdgeLine</returns>
        System.Threading.Tasks.Task<EdgeLine> PutEdgesEdgeIdLinesLineIdAsync (string edgeId, string lineId, EdgeLine body = null);

        /// <summary>
        /// Update a line.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdgeLine>> PutEdgesEdgeIdLinesLineIdAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null);
        
        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        System.Threading.Tasks.Task<DomainLogicalInterface> PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null);

        /// <summary>
        /// Update an edge logical interface.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null);
        
        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        System.Threading.Tasks.Task<Endpoint> PutEndpointsEndpointIdAsync (string endpointId, Endpoint body = null);

        /// <summary>
        /// Update endpoint
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endpoint>> PutEndpointsEndpointIdAsyncWithHttpInfo (string endpointId, Endpoint body = null);
        
        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ExtensionPool</returns>
        System.Threading.Tasks.Task<ExtensionPool> PutExtensionpoolsExtensionpoolIdAsync (string extensionPoolId, ExtensionPool body = null);

        /// <summary>
        /// Update an extension pool by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> PutExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null);
        
        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Extension</returns>
        System.Threading.Tasks.Task<Extension> PutExtensionsExtensionIdAsync (string extensionId, Extension body = null);

        /// <summary>
        /// Update an extension by ID.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        System.Threading.Tasks.Task<ApiResponse<Extension>> PutExtensionsExtensionIdAsyncWithHttpInfo (string extensionId, Extension body = null);
        
        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> PutOrganizationAsync (Organization body = null);

        /// <summary>
        /// Update context organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationAsyncWithHttpInfo (Organization body = null);
        
        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> PutOrganizationsOrgIdAsync (string orgId, Organization body = null);

        /// <summary>
        /// Update organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationsOrgIdAsyncWithHttpInfo (string orgId, Organization body = null);
        
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> PutRecordingkeysRotationscheduleAsync (KeyRotationSchedule body = null);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> PutRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body = null);
        
        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PutRetentionpoliciesPolicyIdAsync (string policyId, Policy body = null);

        /// <summary>
        /// Update policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PutRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null);
        
        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        System.Threading.Tasks.Task<Site> PutSitesSiteIdAsync (string siteId, Site body = null);

        /// <summary>
        /// Update a endpoint.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        System.Threading.Tasks.Task<ApiResponse<Site>> PutSitesSiteIdAsyncWithHttpInfo (string siteId, Site body = null);
        
        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        System.Threading.Tasks.Task<List<NumberPlan>> PutSitesSiteIdNumberplansAsync (string siteId, List<NumberPlan> body = null);

        /// <summary>
        /// Update the list of Number Plans.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> PutSitesSiteIdNumberplansAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfigurationApi : IConfigurationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigurationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigurationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>string</returns>
        public string DeleteDidpoolsDidpoolId (string didPoolId)
        {
             ApiResponse<string> localVarResponse = DeleteDidpoolsDidpoolIdWithHttpInfo(didPoolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteDidpoolsDidpoolIdWithHttpInfo (string didPoolId)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->DeleteDidpoolsDidpoolId");
            
    
            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDidpoolsDidpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDidpoolsDidpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteDidpoolsDidpoolIdAsync (string didPoolId)
        {
             ApiResponse<string> localVarResponse = await DeleteDidpoolsDidpoolIdAsyncWithHttpInfo(didPoolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling DeleteDidpoolsDidpoolId");
            
    
            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDidpoolsDidpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteDidpoolsDidpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>string</returns>
        public string DeleteEdgesCertificateauthoritiesCertificateId (string certificateId)
        {
             ApiResponse<string> localVarResponse = DeleteEdgesCertificateauthoritiesCertificateIdWithHttpInfo(certificateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->DeleteEdgesCertificateauthoritiesCertificateId");
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificateId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificateId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgesCertificateauthoritiesCertificateIdAsync (string certificateId)
        {
             ApiResponse<string> localVarResponse = await DeleteEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo(certificateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling DeleteEdgesCertificateauthoritiesCertificateId");
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificateId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesCertificateauthoritiesCertificateId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string DeleteEdgesEdgeId (string edgeId)
        {
             ApiResponse<string> localVarResponse = DeleteEdgesEdgeIdWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgesEdgeIdWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->DeleteEdgesEdgeId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgesEdgeIdAsync (string edgeId)
        {
             ApiResponse<string> localVarResponse = await DeleteEdgesEdgeIdAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesEdgeIdAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgesEdgeId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns></returns>
        public void DeleteEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId)
        {
             DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo(edgeId, interfaceId);
        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->DeleteEdgesEdgeIdLogicalinterfacesInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->DeleteEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId)
        {
             await DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId);

        }

        /// <summary>
        /// Delete an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string DeleteEdgesEdgeIdSoftwareupdate (string edgeId)
        {
             ApiResponse<string> localVarResponse = DeleteEdgesEdgeIdSoftwareupdateWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->DeleteEdgesEdgeIdSoftwareupdate");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeIdSoftwareupdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeIdSoftwareupdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEdgesEdgeIdSoftwareupdateAsync (string edgeId)
        {
             ApiResponse<string> localVarResponse = await DeleteEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancels any in-progress update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling DeleteEdgesEdgeIdSoftwareupdate");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeIdSoftwareupdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEdgesEdgeIdSoftwareupdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>string</returns>
        public string DeleteEndpointsEndpointId (string endpointId)
        {
             ApiResponse<string> localVarResponse = DeleteEndpointsEndpointIdWithHttpInfo(endpointId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteEndpointsEndpointIdWithHttpInfo (string endpointId)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->DeleteEndpointsEndpointId");
            
    
            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEndpointsEndpointId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEndpointsEndpointId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteEndpointsEndpointIdAsync (string endpointId)
        {
             ApiResponse<string> localVarResponse = await DeleteEndpointsEndpointIdAsyncWithHttpInfo(endpointId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteEndpointsEndpointIdAsyncWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling DeleteEndpointsEndpointId");
            
    
            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEndpointsEndpointId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEndpointsEndpointId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>string</returns>
        public string DeleteExtensionpoolsExtensionpoolId (string extensionPoolId)
        {
             ApiResponse<string> localVarResponse = DeleteExtensionpoolsExtensionpoolIdWithHttpInfo(extensionPoolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->DeleteExtensionpoolsExtensionpoolId");
            
    
            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExtensionpoolsExtensionpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExtensionpoolsExtensionpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteExtensionpoolsExtensionpoolIdAsync (string extensionPoolId)
        {
             ApiResponse<string> localVarResponse = await DeleteExtensionpoolsExtensionpoolIdAsyncWithHttpInfo(extensionPoolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling DeleteExtensionpoolsExtensionpoolId");
            
    
            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExtensionpoolsExtensionpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteExtensionpoolsExtensionpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>string</returns>
        public string DeleteOrganizationsOrgId (string orgId)
        {
             ApiResponse<string> localVarResponse = DeleteOrganizationsOrgIdWithHttpInfo(orgId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteOrganizationsOrgIdWithHttpInfo (string orgId)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->DeleteOrganizationsOrgId");
            
    
            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrganizationsOrgId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrganizationsOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteOrganizationsOrgIdAsync (string orgId)
        {
             ApiResponse<string> localVarResponse = await DeleteOrganizationsOrgIdAsyncWithHttpInfo(orgId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteOrganizationsOrgIdAsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling DeleteOrganizationsOrgId");
            
    
            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrganizationsOrgId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrganizationsOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param> 
        /// <returns>string</returns>
        public string DeleteRetentionpolicies (string ids)
        {
             ApiResponse<string> localVarResponse = DeleteRetentionpoliciesWithHttpInfo(ids);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteRetentionpoliciesWithHttpInfo (string ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling ConfigurationApi->DeleteRetentionpolicies");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (ids != null) localVarQueryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRetentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRetentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteRetentionpoliciesAsync (string ids)
        {
             ApiResponse<string> localVarResponse = await DeleteRetentionpoliciesAsyncWithHttpInfo(ids);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete policies Bulk delete of Rules from specified rule set, this will only delete the rules that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesAsyncWithHttpInfo (string ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling DeleteRetentionpolicies");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (ids != null) localVarQueryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRetentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRetentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>string</returns>
        public string DeleteRetentionpoliciesPolicyId (string policyId)
        {
             ApiResponse<string> localVarResponse = DeleteRetentionpoliciesPolicyIdWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteRetentionpoliciesPolicyIdWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->DeleteRetentionpoliciesPolicyId");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRetentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRetentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteRetentionpoliciesPolicyIdAsync (string policyId)
        {
             ApiResponse<string> localVarResponse = await DeleteRetentionpoliciesPolicyIdAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling DeleteRetentionpoliciesPolicyId");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRetentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteRetentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <returns>string</returns>
        public string DeleteSitesSiteId (string siteId)
        {
             ApiResponse<string> localVarResponse = DeleteSitesSiteIdWithHttpInfo(siteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteSitesSiteIdWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->DeleteSitesSiteId");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSitesSiteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSitesSiteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteSitesSiteIdAsync (string siteId)
        {
             ApiResponse<string> localVarResponse = await DeleteSitesSiteIdAsyncWithHttpInfo(siteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete an ednpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteSitesSiteIdAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling DeleteSitesSiteId");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSitesSiteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteSitesSiteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>DIDPoolEntityListing</returns>
        public DIDPoolEntityListing GetDidpools (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<DIDPoolEntityListing> localVarResponse = GetDidpoolsWithHttpInfo(pageSize, pageNumber, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of DIDPoolEntityListing</returns>
        public ApiResponse< DIDPoolEntityListing > GetDidpoolsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/didpools";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDidpools: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDidpools: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DIDPoolEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPoolEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPoolEntityListing)));
            
        }

        
        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of DIDPoolEntityListing</returns>
        public async System.Threading.Tasks.Task<DIDPoolEntityListing> GetDidpoolsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
             ApiResponse<DIDPoolEntityListing> localVarResponse = await GetDidpoolsAsyncWithHttpInfo(pageSize, pageNumber, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of DID Pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (DIDPoolEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPoolEntityListing>> GetDidpoolsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/didpools";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDidpools: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDidpools: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPoolEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPoolEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPoolEntityListing)));
            
        }
        
        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>DIDPool</returns>
        public DIDPool GetDidpoolsDidpoolId (string didPoolId)
        {
             ApiResponse<DIDPool> localVarResponse = GetDidpoolsDidpoolIdWithHttpInfo(didPoolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > GetDidpoolsDidpoolIdWithHttpInfo (string didPoolId)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->GetDidpoolsDidpoolId");
            
    
            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDidpoolsDidpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDidpoolsDidpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }

        
        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> GetDidpoolsDidpoolIdAsync (string didPoolId)
        {
             ApiResponse<DIDPool> localVarResponse = await GetDidpoolsDidpoolIdAsyncWithHttpInfo(didPoolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> GetDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling GetDidpoolsDidpoolId");
            
    
            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDidpoolsDidpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDidpoolsDidpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }
        
        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="phoneNumber">Filter by phoneNumber</param> 
        /// <returns>DIDEntityListing</returns>
        public DIDEntityListing GetDids (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
             ApiResponse<DIDEntityListing> localVarResponse = GetDidsWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="phoneNumber">Filter by phoneNumber</param> 
        /// <returns>ApiResponse of DIDEntityListing</returns>
        public ApiResponse< DIDEntityListing > GetDidsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/dids";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDids: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDids: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DIDEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDEntityListing)));
            
        }

        
        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>Task of DIDEntityListing</returns>
        public async System.Threading.Tasks.Task<DIDEntityListing> GetDidsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
             ApiResponse<DIDEntityListing> localVarResponse = await GetDidsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, phoneNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of DIDs 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="phoneNumber">Filter by phoneNumber</param>
        /// <returns>Task of ApiResponse (DIDEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDEntityListing>> GetDidsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string phoneNumber = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/dids";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDids: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDids: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDEntityListing)));
            
        }
        
        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param> 
        /// <returns>DID</returns>
        public DID GetDidsDidId (string didId)
        {
             ApiResponse<DID> localVarResponse = GetDidsDidIdWithHttpInfo(didId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param> 
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > GetDidsDidIdWithHttpInfo (string didId)
        {
            
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->GetDidsDidId");
            
    
            var localVarPath = "/api/v1/configuration/dids/{didId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didId != null) localVarPathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDidsDidId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDidsDidId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DID>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DID)));
            
        }

        
        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of DID</returns>
        public async System.Threading.Tasks.Task<DID> GetDidsDidIdAsync (string didId)
        {
             ApiResponse<DID> localVarResponse = await GetDidsDidIdAsyncWithHttpInfo(didId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> GetDidsDidIdAsyncWithHttpInfo (string didId)
        {
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling GetDidsDidId");
            
    
            var localVarPath = "/api/v1/configuration/dids/{didId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didId != null) localVarPathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDidsDidId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDidsDidId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DID>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DID)));
            
        }
        
        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>EdgeEntityListing</returns>
        public EdgeEntityListing GetEdges (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
             ApiResponse<EdgeEntityListing> localVarResponse = GetEdgesWithHttpInfo(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="siteId">Filter by site.id</param> 
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of EdgeEntityListing</returns>
        public ApiResponse< EdgeEntityListing > GetEdgesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/edges";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (siteId != null) localVarQueryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (edgeGroupId != null) localVarQueryParams.Add("edgeGroup.id", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdges: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdges: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EdgeEntityListing</returns>
        public async System.Threading.Tasks.Task<EdgeEntityListing> GetEdgesAsync (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
             ApiResponse<EdgeEntityListing> localVarResponse = await GetEdgesAsyncWithHttpInfo(pageSize, pageNumber, name, siteId, edgeGroupId, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of edges. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="siteId">Filter by site.id</param>
        /// <param name="edgeGroupId">Filter by edgeGroup.id</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EdgeEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeEntityListing>> GetEdgesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/edges";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (siteId != null) localVarQueryParams.Add("site.id", Configuration.ApiClient.ParameterToString(siteId)); // query parameter
            if (edgeGroupId != null) localVarQueryParams.Add("edgeGroup.id", Configuration.ApiClient.ParameterToString(edgeGroupId)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdges: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdges: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeEntityListing)));
            
        }
        
        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CertificateAuthorityEntityListing</returns>
        public CertificateAuthorityEntityListing GetEdgesCertificateauthorities ()
        {
             ApiResponse<CertificateAuthorityEntityListing> localVarResponse = GetEdgesCertificateauthoritiesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CertificateAuthorityEntityListing</returns>
        public ApiResponse< CertificateAuthorityEntityListing > GetEdgesCertificateauthoritiesWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesCertificateauthorities: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesCertificateauthorities: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CertificateAuthorityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CertificateAuthorityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CertificateAuthorityEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CertificateAuthorityEntityListing</returns>
        public async System.Threading.Tasks.Task<CertificateAuthorityEntityListing> GetEdgesCertificateauthoritiesAsync ()
        {
             ApiResponse<CertificateAuthorityEntityListing> localVarResponse = await GetEdgesCertificateauthoritiesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of certificate authorities. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CertificateAuthorityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CertificateAuthorityEntityListing>> GetEdgesCertificateauthoritiesAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesCertificateauthorities: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesCertificateauthorities: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CertificateAuthorityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CertificateAuthorityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CertificateAuthorityEntityListing)));
            
        }
        
        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority GetEdgesCertificateauthoritiesCertificateId (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = GetEdgesCertificateauthoritiesCertificateIdWithHttpInfo(certificateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > GetEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->GetEdgesCertificateauthoritiesCertificateId");
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesCertificateauthoritiesCertificateId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesCertificateauthoritiesCertificateId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }

        
        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> GetEdgesCertificateauthoritiesCertificateIdAsync (string certificateId)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = await GetEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo(certificateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> GetEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling GetEdgesCertificateauthoritiesCertificateId");
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesCertificateauthoritiesCertificateId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesCertificateauthoritiesCertificateId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }
        
        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>Edge</returns>
        public Edge GetEdgesEdgeId (string edgeId)
        {
             ApiResponse<Edge> localVarResponse = GetEdgesEdgeIdWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > GetEdgesEdgeIdWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }

        
        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> GetEdgesEdgeIdAsync (string edgeId)
        {
             ApiResponse<Edge> localVarResponse = await GetEdgesEdgeIdAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> GetEdgesEdgeIdAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }
        
        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>EdgeLineEntityListing</returns>
        public EdgeLineEntityListing GetEdgesEdgeIdLines (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EdgeLineEntityListing> localVarResponse = GetEdgesEdgeIdLinesWithHttpInfo(edgeId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of EdgeLineEntityListing</returns>
        public ApiResponse< EdgeLineEntityListing > GetEdgesEdgeIdLinesWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLines");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLines: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeLineEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLineEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLineEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EdgeLineEntityListing</returns>
        public async System.Threading.Tasks.Task<EdgeLineEntityListing> GetEdgesEdgeIdLinesAsync (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EdgeLineEntityListing> localVarResponse = await GetEdgesEdgeIdLinesAsyncWithHttpInfo(edgeId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of lines. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EdgeLineEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLineEntityListing>> GetEdgesEdgeIdLinesAsyncWithHttpInfo (string edgeId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLines");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLines: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLines: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLineEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLineEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLineEntityListing)));
            
        }
        
        /// <summary>
        /// Get line 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <returns>EdgeLine</returns>
        public EdgeLine GetEdgesEdgeIdLinesLineId (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> localVarResponse = GetEdgesEdgeIdLinesLineIdWithHttpInfo(edgeId, lineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > GetEdgesEdgeIdLinesLineIdWithHttpInfo (string edgeId, string lineId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLinesLineId");
            
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->GetEdgesEdgeIdLinesLineId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) localVarPathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLinesLineId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLinesLineId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLine)));
            
        }

        
        /// <summary>
        /// Get line 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of EdgeLine</returns>
        public async System.Threading.Tasks.Task<EdgeLine> GetEdgesEdgeIdLinesLineIdAsync (string edgeId, string lineId)
        {
             ApiResponse<EdgeLine> localVarResponse = await GetEdgesEdgeIdLinesLineIdAsyncWithHttpInfo(edgeId, lineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get line 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> GetEdgesEdgeIdLinesLineIdAsyncWithHttpInfo (string edgeId, string lineId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLinesLineId");
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling GetEdgesEdgeIdLinesLineId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) localVarPathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLinesLineId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLinesLineId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLine)));
            
        }
        
        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>LogicalInterfaceEntityListing</returns>
        public LogicalInterfaceEntityListing GetEdgesEdgeIdLogicalinterfaces (string edgeId)
        {
             ApiResponse<LogicalInterfaceEntityListing> localVarResponse = GetEdgesEdgeIdLogicalinterfacesWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of LogicalInterfaceEntityListing</returns>
        public ApiResponse< LogicalInterfaceEntityListing > GetEdgesEdgeIdLogicalinterfacesWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLogicalinterfaces");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogicalinterfaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogicalinterfaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LogicalInterfaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogicalInterfaceEntityListing)));
            
        }

        
        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of LogicalInterfaceEntityListing</returns>
        public async System.Threading.Tasks.Task<LogicalInterfaceEntityListing> GetEdgesEdgeIdLogicalinterfacesAsync (string edgeId)
        {
             ApiResponse<LogicalInterfaceEntityListing> localVarResponse = await GetEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get edge logical interfaces. Retrieve a list of all configured logical interfaces from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (LogicalInterfaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LogicalInterfaceEntityListing>> GetEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLogicalinterfaces");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogicalinterfaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogicalinterfaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LogicalInterfaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LogicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LogicalInterfaceEntityListing)));
            
        }
        
        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>DomainLogicalInterface</returns>
        public DomainLogicalInterface GetEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = GetEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo(edgeId, interfaceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > GetEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLogicalinterfacesInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->GetEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }

        
        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainLogicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainLogicalInterface> GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = await GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an edge logical interface 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> GetEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLogicalinterfacesInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }
        
        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId">Job ID</param> 
        /// <returns>EdgeLogsJob</returns>
        public EdgeLogsJob GetEdgesEdgeIdLogsJobsJobId (string edgeId, string jobId)
        {
             ApiResponse<EdgeLogsJob> localVarResponse = GetEdgesEdgeIdLogsJobsJobIdWithHttpInfo(edgeId, jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId">Job ID</param> 
        /// <returns>ApiResponse of EdgeLogsJob</returns>
        public ApiResponse< EdgeLogsJob > GetEdgesEdgeIdLogsJobsJobIdWithHttpInfo (string edgeId, string jobId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdLogsJobsJobId");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ConfigurationApi->GetEdgesEdgeIdLogsJobsJobId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logs/jobs/{jobId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (jobId != null) localVarPathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogsJobsJobId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogsJobsJobId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeLogsJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLogsJob) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLogsJob)));
            
        }

        
        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of EdgeLogsJob</returns>
        public async System.Threading.Tasks.Task<EdgeLogsJob> GetEdgesEdgeIdLogsJobsJobIdAsync (string edgeId, string jobId)
        {
             ApiResponse<EdgeLogsJob> localVarResponse = await GetEdgesEdgeIdLogsJobsJobIdAsyncWithHttpInfo(edgeId, jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an Edge logs job. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (EdgeLogsJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLogsJob>> GetEdgesEdgeIdLogsJobsJobIdAsyncWithHttpInfo (string edgeId, string jobId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdLogsJobsJobId");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling GetEdgesEdgeIdLogsJobsJobId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logs/jobs/{jobId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (jobId != null) localVarPathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogsJobsJobId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdLogsJobsJobId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLogsJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLogsJob) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLogsJob)));
            
        }
        
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>PhysicalInterfaceEntityListing</returns>
        public PhysicalInterfaceEntityListing GetEdgesEdgeIdPhysicalinterfaces (string edgeId)
        {
             ApiResponse<PhysicalInterfaceEntityListing> localVarResponse = GetEdgesEdgeIdPhysicalinterfacesWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of PhysicalInterfaceEntityListing</returns>
        public ApiResponse< PhysicalInterfaceEntityListing > GetEdgesEdgeIdPhysicalinterfacesWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdPhysicalinterfaces");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdPhysicalinterfaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdPhysicalinterfaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PhysicalInterfaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhysicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhysicalInterfaceEntityListing)));
            
        }

        
        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of PhysicalInterfaceEntityListing</returns>
        public async System.Threading.Tasks.Task<PhysicalInterfaceEntityListing> GetEdgesEdgeIdPhysicalinterfacesAsync (string edgeId)
        {
             ApiResponse<PhysicalInterfaceEntityListing> localVarResponse = await GetEdgesEdgeIdPhysicalinterfacesAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of all configured physical interfaces from a specific edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (PhysicalInterfaceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhysicalInterfaceEntityListing>> GetEdgesEdgeIdPhysicalinterfacesAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdPhysicalinterfaces");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdPhysicalinterfaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdPhysicalinterfaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhysicalInterfaceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhysicalInterfaceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhysicalInterfaceEntityListing)));
            
        }
        
        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>DomainPhysicalInterface</returns>
        public DomainPhysicalInterface GetEdgesEdgeIdPhysicalinterfacesInterfaceId (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> localVarResponse = GetEdgesEdgeIdPhysicalinterfacesInterfaceIdWithHttpInfo(edgeId, interfaceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <returns>ApiResponse of DomainPhysicalInterface</returns>
        public ApiResponse< DomainPhysicalInterface > GetEdgesEdgeIdPhysicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdPhysicalinterfacesInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->GetEdgesEdgeIdPhysicalinterfacesInterfaceId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces/{interfaceId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainPhysicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainPhysicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainPhysicalInterface)));
            
        }

        
        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of DomainPhysicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainPhysicalInterface> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId)
        {
             ApiResponse<DomainPhysicalInterface> localVarResponse = await GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get edge physical interface. Retrieve a physical interface from a specific edge.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <returns>Task of ApiResponse (DomainPhysicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainPhysicalInterface>> GetEdgesEdgeIdPhysicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/physicalinterfaces/{interfaceId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdPhysicalinterfacesInterfaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainPhysicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainPhysicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainPhysicalInterface)));
            
        }
        
        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        public DomainEdgeSoftwareUpdateDto GetEdgesEdgeIdSoftwareupdate (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> localVarResponse = GetEdgesEdgeIdSoftwareupdateWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        public ApiResponse< DomainEdgeSoftwareUpdateDto > GetEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdSoftwareupdate");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdSoftwareupdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdSoftwareupdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }

        
        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> GetEdgesEdgeIdSoftwareupdateAsync (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> localVarResponse = await GetEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets software update status information about any edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> GetEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdSoftwareupdate");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdSoftwareupdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdSoftwareupdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }
        
        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>DomainEdgeSoftwareVersionDto</returns>
        public DomainEdgeSoftwareVersionDto GetEdgesEdgeIdSoftwareversions (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareVersionDto> localVarResponse = GetEdgesEdgeIdSoftwareversionsWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of DomainEdgeSoftwareVersionDto</returns>
        public ApiResponse< DomainEdgeSoftwareVersionDto > GetEdgesEdgeIdSoftwareversionsWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->GetEdgesEdgeIdSoftwareversions");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareversions";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdSoftwareversions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdSoftwareversions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainEdgeSoftwareVersionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareVersionDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareVersionDto)));
            
        }

        
        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of DomainEdgeSoftwareVersionDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareVersionDto> GetEdgesEdgeIdSoftwareversionsAsync (string edgeId)
        {
             ApiResponse<DomainEdgeSoftwareVersionDto> localVarResponse = await GetEdgesEdgeIdSoftwareversionsAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all the available software versions for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareVersionDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareVersionDto>> GetEdgesEdgeIdSoftwareversionsAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling GetEdgesEdgeIdSoftwareversions");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareversions";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdSoftwareversions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgesEdgeIdSoftwareversions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareVersionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareVersionDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareVersionDto)));
            
        }
        
        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EdgeVersionReport</returns>
        public EdgeVersionReport GetEdgeversionreport ()
        {
             ApiResponse<EdgeVersionReport> localVarResponse = GetEdgeversionreportWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EdgeVersionReport</returns>
        public ApiResponse< EdgeVersionReport > GetEdgeversionreportWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/edgeversionreport";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgeversionreport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgeversionreport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeVersionReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeVersionReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeVersionReport)));
            
        }

        
        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EdgeVersionReport</returns>
        public async System.Threading.Tasks.Task<EdgeVersionReport> GetEdgeversionreportAsync ()
        {
             ApiResponse<EdgeVersionReport> localVarResponse = await GetEdgeversionreportAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the edge version report. The report will not have consistent data about the edge version(s) until all edges have been reset.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EdgeVersionReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeVersionReport>> GetEdgeversionreportAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/edgeversionreport";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgeversionreport: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEdgeversionreport: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeVersionReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeVersionReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeVersionReport)));
            
        }
        
        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>EndpointEntityListing</returns>
        public EndpointEntityListing GetEndpoints (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EndpointEntityListing> localVarResponse = GetEndpointsWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="name">Name</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <returns>ApiResponse of EndpointEntityListing</returns>
        public ApiResponse< EndpointEntityListing > GetEndpointsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/endpoints";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEndpoints: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEndpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EndpointEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EndpointEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EndpointEntityListing)));
            
        }

        
        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of EndpointEntityListing</returns>
        public async System.Threading.Tasks.Task<EndpointEntityListing> GetEndpointsAsync (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
             ApiResponse<EndpointEntityListing> localVarResponse = await GetEndpointsAsyncWithHttpInfo(pageSize, pageNumber, name, sortBy);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get endpoints 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="name">Name</param>
        /// <param name="sortBy">Sort by</param>
        /// <returns>Task of ApiResponse (EndpointEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EndpointEntityListing>> GetEndpointsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/endpoints";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEndpoints: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEndpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EndpointEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EndpointEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EndpointEntityListing)));
            
        }
        
        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>Endpoint</returns>
        public Endpoint GetEndpointsEndpointId (string endpointId)
        {
             ApiResponse<Endpoint> localVarResponse = GetEndpointsEndpointIdWithHttpInfo(endpointId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > GetEndpointsEndpointIdWithHttpInfo (string endpointId)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->GetEndpointsEndpointId");
            
    
            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEndpointsEndpointId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEndpointsEndpointId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }

        
        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> GetEndpointsEndpointIdAsync (string endpointId)
        {
             ApiResponse<Endpoint> localVarResponse = await GetEndpointsEndpointIdAsyncWithHttpInfo(endpointId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> GetEndpointsEndpointIdAsyncWithHttpInfo (string endpointId)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling GetEndpointsEndpointId");
            
    
            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetEndpointsEndpointId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEndpointsEndpointId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }
        
        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="number">Number</param> 
        /// <returns>ExtensionPoolEntityListing</returns>
        public ExtensionPoolEntityListing GetExtensionpools (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
             ApiResponse<ExtensionPoolEntityListing> localVarResponse = GetExtensionpoolsWithHttpInfo(pageSize, pageNumber, sortBy, number);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="number">Number</param> 
        /// <returns>ApiResponse of ExtensionPoolEntityListing</returns>
        public ApiResponse< ExtensionPoolEntityListing > GetExtensionpoolsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/extensionpools";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (number != null) localVarQueryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionpools: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionpools: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExtensionPoolEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPoolEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPoolEntityListing)));
            
        }

        
        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>Task of ExtensionPoolEntityListing</returns>
        public async System.Threading.Tasks.Task<ExtensionPoolEntityListing> GetExtensionpoolsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
             ApiResponse<ExtensionPoolEntityListing> localVarResponse = await GetExtensionpoolsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, number);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of extension pools 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="number">Number</param>
        /// <returns>Task of ApiResponse (ExtensionPoolEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPoolEntityListing>> GetExtensionpoolsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string number = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/extensionpools";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (number != null) localVarQueryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionpools: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionpools: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionPoolEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPoolEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPoolEntityListing)));
            
        }
        
        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ExtensionPool</returns>
        public ExtensionPool GetExtensionpoolsExtensionpoolId (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> localVarResponse = GetExtensionpoolsExtensionpoolIdWithHttpInfo(extensionPoolId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > GetExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->GetExtensionpoolsExtensionpoolId");
            
    
            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionpoolsExtensionpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionpoolsExtensionpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExtensionPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPool)));
            
        }

        
        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ExtensionPool</returns>
        public async System.Threading.Tasks.Task<ExtensionPool> GetExtensionpoolsExtensionpoolIdAsync (string extensionPoolId)
        {
             ApiResponse<ExtensionPool> localVarResponse = await GetExtensionpoolsExtensionpoolIdAsyncWithHttpInfo(extensionPoolId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> GetExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling GetExtensionpoolsExtensionpoolId");
            
    
            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionpoolsExtensionpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionpoolsExtensionpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPool)));
            
        }
        
        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="number">Filter by number</param> 
        /// <returns>ExtensionEntityListing</returns>
        public ExtensionEntityListing GetExtensions (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
             ApiResponse<ExtensionEntityListing> localVarResponse = GetExtensionsWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, number);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="number">Filter by number</param> 
        /// <returns>ApiResponse of ExtensionEntityListing</returns>
        public ApiResponse< ExtensionEntityListing > GetExtensionsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/extensions";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (number != null) localVarQueryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExtensionEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionEntityListing)));
            
        }

        
        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>Task of ExtensionEntityListing</returns>
        public async System.Threading.Tasks.Task<ExtensionEntityListing> GetExtensionsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
             ApiResponse<ExtensionEntityListing> localVarResponse = await GetExtensionsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, number);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a listing of extensions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="number">Filter by number</param>
        /// <returns>Task of ApiResponse (ExtensionEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionEntityListing>> GetExtensionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string number = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/extensions";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (number != null) localVarQueryParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionEntityListing)));
            
        }
        
        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param> 
        /// <returns>Extension</returns>
        public Extension GetExtensionsExtensionId (string extensionId)
        {
             ApiResponse<Extension> localVarResponse = GetExtensionsExtensionIdWithHttpInfo(extensionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > GetExtensionsExtensionIdWithHttpInfo (string extensionId)
        {
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->GetExtensionsExtensionId");
            
    
            var localVarPath = "/api/v1/configuration/extensions/{extensionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionsExtensionId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionsExtensionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }

        
        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> GetExtensionsExtensionIdAsync (string extensionId)
        {
             ApiResponse<Extension> localVarResponse = await GetExtensionsExtensionIdAsyncWithHttpInfo(extensionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> GetExtensionsExtensionIdAsyncWithHttpInfo (string extensionId)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling GetExtensionsExtensionId");
            
    
            var localVarPath = "/api/v1/configuration/extensions/{extensionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionsExtensionId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetExtensionsExtensionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }
        
        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Organization</returns>
        public Organization GetOrganization ()
        {
             ApiResponse<Organization> localVarResponse = GetOrganizationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetOrganizationWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/organization";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        
        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetOrganizationAsync ()
        {
             ApiResponse<Organization> localVarResponse = await GetOrganizationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/organization";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>Organization</returns>
        public Organization GetOrganizationsOrgId (string orgId)
        {
             ApiResponse<Organization> localVarResponse = GetOrganizationsOrgIdWithHttpInfo(orgId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetOrganizationsOrgIdWithHttpInfo (string orgId)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->GetOrganizationsOrgId");
            
    
            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsOrgId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        
        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetOrganizationsOrgIdAsync (string orgId)
        {
             ApiResponse<Organization> localVarResponse = await GetOrganizationsOrgIdAsyncWithHttpInfo(orgId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetOrganizationsOrgIdAsyncWithHttpInfo (string orgId)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling GetOrganizationsOrgId");
            
    
            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsOrgId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrganizationsOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>EncryptionKeyEntityListing</returns>
        public EncryptionKeyEntityListing GetRecordingkeys (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> localVarResponse = GetRecordingkeysWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        public ApiResponse< EncryptionKeyEntityListing > GetRecordingkeysWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/recordingkeys";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EncryptionKeyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKeyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKeyEntityListing)));
            
        }

        
        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        public async System.Threading.Tasks.Task<EncryptionKeyEntityListing> GetRecordingkeysAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> localVarResponse = await GetRecordingkeysAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> GetRecordingkeysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/recordingkeys";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKeyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKeyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKeyEntityListing)));
            
        }
        
        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule GetRecordingkeysRotationschedule ()
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = GetRecordingkeysRotationscheduleWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > GetRecordingkeysRotationscheduleWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/recordingkeys/rotationschedule";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        
        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> GetRecordingkeysRotationscheduleAsync ()
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = await GetRecordingkeysRotationscheduleAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> GetRecordingkeysRotationscheduleAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/recordingkeys/rotationschedule";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }
        
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="name">the policy name - used for filtering results in searches.</param> 
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param> 
        /// <param name="summary">provides a less verbose response of policy lists.</param> 
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param> 
        /// <returns>PolicyEntityListing</returns>
        public PolicyEntityListing GetRetentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = GetRetentionpoliciesWithHttpInfo(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="name">the policy name - used for filtering results in searches.</param> 
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param> 
        /// <param name="summary">provides a less verbose response of policy lists.</param> 
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param> 
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        public ApiResponse< PolicyEntityListing > GetRetentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            if (summary != null) localVarQueryParams.Add("summary", Configuration.ApiClient.ParameterToString(summary)); // query parameter
            if (hasErrors != null) localVarQueryParams.Add("hasErrors", Configuration.ApiClient.ParameterToString(hasErrors)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRetentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRetentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)));
            
        }

        
        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>Task of PolicyEntityListing</returns>
        public async System.Threading.Tasks.Task<PolicyEntityListing> GetRetentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = await GetRetentionpoliciesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, name, enabled, summary, hasErrors);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets retention policy list with query options to filter on name and enabled. for a less verbose response, add summary=true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="name">the policy name - used for filtering results in searches.</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled = true or enabled = false</param>
        /// <param name="summary">provides a less verbose response of policy lists.</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetRetentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            if (summary != null) localVarQueryParams.Add("summary", Configuration.ApiClient.ParameterToString(summary)); // query parameter
            if (hasErrors != null) localVarQueryParams.Add("hasErrors", Configuration.ApiClient.ParameterToString(hasErrors)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRetentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRetentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)));
            
        }
        
        /// <summary>
        /// Get policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>Policy</returns>
        public Policy GetRetentionpoliciesPolicyId (string policyId)
        {
             ApiResponse<Policy> localVarResponse = GetRetentionpoliciesPolicyIdWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > GetRetentionpoliciesPolicyIdWithHttpInfo (string policyId)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->GetRetentionpoliciesPolicyId");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRetentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRetentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        
        /// <summary>
        /// Get policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> GetRetentionpoliciesPolicyIdAsync (string policyId)
        {
             ApiResponse<Policy> localVarResponse = await GetRetentionpoliciesPolicyIdAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> GetRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling GetRetentionpoliciesPolicyId");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetRetentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRetentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>SchemaCategoryEntityListing</returns>
        public SchemaCategoryEntityListing GetSchemasEdgesVnext (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaCategoryEntityListing> localVarResponse = GetSchemasEdgesVnextWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of SchemaCategoryEntityListing</returns>
        public ApiResponse< SchemaCategoryEntityListing > GetSchemasEdgesVnextWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnext: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnext: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SchemaCategoryEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaCategoryEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaCategoryEntityListing)));
            
        }

        
        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaCategoryEntityListing</returns>
        public async System.Threading.Tasks.Task<SchemaCategoryEntityListing> GetSchemasEdgesVnextAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaCategoryEntityListing> localVarResponse = await GetSchemasEdgesVnextAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lists available schema categories 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaCategoryEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaCategoryEntityListing>> GetSchemasEdgesVnextAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnext: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnext: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaCategoryEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaCategoryEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaCategoryEntityListing)));
            
        }
        
        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>SchemaReferenceEntityListing</returns>
        public SchemaReferenceEntityListing GetSchemasEdgesVnextSchemacategory (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> localVarResponse = GetSchemasEdgesVnextSchemacategoryWithHttpInfo(schemaCategory, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        public ApiResponse< SchemaReferenceEntityListing > GetSchemasEdgesVnextSchemacategoryWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategory");
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SchemaReferenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaReferenceEntityListing)));
            
        }

        
        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategoryAsync (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> localVarResponse = await GetSchemasEdgesVnextSchemacategoryAsyncWithHttpInfo(schemaCategory, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemacategoryAsyncWithHttpInfo (string schemaCategory, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemacategory");
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaReferenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaReferenceEntityListing)));
            
        }
        
        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>SchemaReferenceEntityListing</returns>
        public SchemaReferenceEntityListing GetSchemasEdgesVnextSchemacategorySchematype (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> localVarResponse = GetSchemasEdgesVnextSchemacategorySchematypeWithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <returns>ApiResponse of SchemaReferenceEntityListing</returns>
        public ApiResponse< SchemaReferenceEntityListing > GetSchemasEdgesVnextSchemacategorySchematypeWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematype");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematype");
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematype: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SchemaReferenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaReferenceEntityListing)));
            
        }

        
        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of SchemaReferenceEntityListing</returns>
        public async System.Threading.Tasks.Task<SchemaReferenceEntityListing> GetSchemasEdgesVnextSchemacategorySchematypeAsync (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<SchemaReferenceEntityListing> localVarResponse = await GetSchemasEdgesVnextSchemacategorySchematypeAsyncWithHttpInfo(schemaCategory, schemaType, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List schemas of a specific category 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <returns>Task of ApiResponse (SchemaReferenceEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SchemaReferenceEntityListing>> GetSchemasEdgesVnextSchemacategorySchematypeAsyncWithHttpInfo (string schemaCategory, string schemaType, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemacategorySchematype");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemacategorySchematype");
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematype: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematype: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SchemaReferenceEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SchemaReferenceEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaReferenceEntityListing)));
            
        }
        
        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <returns>Organization</returns>
        public Organization GetSchemasEdgesVnextSchemacategorySchematypeSchemaId (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> localVarResponse = GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdWithHttpInfo(schemaCategory, schemaType, schemaId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) localVarPathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        
        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsync (string schemaCategory, string schemaType, string schemaId)
        {
             ApiResponse<Organization> localVarResponse = await GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsyncWithHttpInfo(schemaCategory, schemaType, schemaId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a json schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId");
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) localVarPathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <param name="extension">extension</param> 
        /// <param name="metadataId">Metadata ID</param> 
        /// <param name="type">Type</param> 
        /// <returns>Organization</returns>
        public Organization GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> localVarResponse = GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdWithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param> 
        /// <param name="schemaType">Schema type</param> 
        /// <param name="schemaId">Schema ID</param> 
        /// <param name="extension">extension</param> 
        /// <param name="metadataId">Metadata ID</param> 
        /// <param name="type">Type</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null)
                throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
            // verify the required parameter 'schemaType' is set
            if (schemaType == null)
                throw new ApiException(400, "Missing required parameter 'schemaType' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
            // verify the required parameter 'schemaId' is set
            if (schemaId == null)
                throw new ApiException(400, "Missing required parameter 'schemaId' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
            // verify the required parameter 'extension' is set
            if (extension == null)
                throw new ApiException(400, "Missing required parameter 'extension' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
            // verify the required parameter 'metadataId' is set
            if (metadataId == null)
                throw new ApiException(400, "Missing required parameter 'metadataId' when calling ConfigurationApi->GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) localVarPathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            if (extension != null) localVarPathParams.Add("extension", Configuration.ApiClient.ParameterToString(extension)); // path parameter
            if (metadataId != null) localVarPathParams.Add("metadataId", Configuration.ApiClient.ParameterToString(metadataId)); // path parameter
            
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        
        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsync (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
             ApiResponse<Organization> localVarResponse = await GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsyncWithHttpInfo(schemaCategory, schemaType, schemaId, extension, metadataId, type);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get metadata for a schema 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="schemaCategory">Schema category</param>
        /// <param name="schemaType">Schema type</param>
        /// <param name="schemaId">Schema ID</param>
        /// <param name="extension">extension</param>
        /// <param name="metadataId">Metadata ID</param>
        /// <param name="type">Type</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataIdAsyncWithHttpInfo (string schemaCategory, string schemaType, string schemaId, string extension, string metadataId, string type = null)
        {
            // verify the required parameter 'schemaCategory' is set
            if (schemaCategory == null) throw new ApiException(400, "Missing required parameter 'schemaCategory' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            // verify the required parameter 'schemaType' is set
            if (schemaType == null) throw new ApiException(400, "Missing required parameter 'schemaType' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            // verify the required parameter 'schemaId' is set
            if (schemaId == null) throw new ApiException(400, "Missing required parameter 'schemaId' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            // verify the required parameter 'extension' is set
            if (extension == null) throw new ApiException(400, "Missing required parameter 'extension' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            // verify the required parameter 'metadataId' is set
            if (metadataId == null) throw new ApiException(400, "Missing required parameter 'metadataId' when calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId");
            
    
            var localVarPath = "/api/v1/configuration/schemas/edges/vnext/{schemaCategory}/{schemaType}/{schemaId}/{extension}/{metadataId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (schemaCategory != null) localVarPathParams.Add("schemaCategory", Configuration.ApiClient.ParameterToString(schemaCategory)); // path parameter
            if (schemaType != null) localVarPathParams.Add("schemaType", Configuration.ApiClient.ParameterToString(schemaType)); // path parameter
            if (schemaId != null) localVarPathParams.Add("schemaId", Configuration.ApiClient.ParameterToString(schemaId)); // path parameter
            if (extension != null) localVarPathParams.Add("extension", Configuration.ApiClient.ParameterToString(extension)); // path parameter
            if (metadataId != null) localVarPathParams.Add("metadataId", Configuration.ApiClient.ParameterToString(metadataId)); // path parameter
            
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSchemasEdgesVnextSchemacategorySchematypeSchemaIdExtensionMetadataId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="name">Name</param> 
        /// <param name="locationId">Location Id</param> 
        /// <returns>SiteEntityListing</returns>
        public SiteEntityListing GetSites (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
             ApiResponse<SiteEntityListing> localVarResponse = GetSitesWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, name, locationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param> 
        /// <param name="pageNumber">Page number</param> 
        /// <param name="sortBy">Sort by</param> 
        /// <param name="sortOrder">Sort order</param> 
        /// <param name="name">Name</param> 
        /// <param name="locationId">Location Id</param> 
        /// <returns>ApiResponse of SiteEntityListing</returns>
        public ApiResponse< SiteEntityListing > GetSitesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/sites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (locationId != null) localVarQueryParams.Add("location.id", Configuration.ApiClient.ParameterToString(locationId)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SiteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SiteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SiteEntityListing)));
            
        }

        
        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>Task of SiteEntityListing</returns>
        public async System.Threading.Tasks.Task<SiteEntityListing> GetSitesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
             ApiResponse<SiteEntityListing> localVarResponse = await GetSitesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, sortOrder, name, locationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of sites. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="sortBy">Sort by</param>
        /// <param name="sortOrder">Sort order</param>
        /// <param name="name">Name</param>
        /// <param name="locationId">Location Id</param>
        /// <returns>Task of ApiResponse (SiteEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SiteEntityListing>> GetSitesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/sites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortOrder != null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (locationId != null) localVarQueryParams.Add("location.id", Configuration.ApiClient.ParameterToString(locationId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SiteEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SiteEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SiteEntityListing)));
            
        }
        
        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <returns>Site</returns>
        public Site GetSitesSiteId (string siteId)
        {
             ApiResponse<Site> localVarResponse = GetSitesSiteIdWithHttpInfo(siteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > GetSitesSiteIdWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSitesSiteId");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }

        
        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> GetSitesSiteIdAsync (string siteId)
        {
             ApiResponse<Site> localVarResponse = await GetSitesSiteIdAsyncWithHttpInfo(siteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> GetSitesSiteIdAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSitesSiteId");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }
        
        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <returns>List&lt;NumberPlan&gt;</returns>
        public List<NumberPlan> GetSitesSiteIdNumberplans (string siteId)
        {
             ApiResponse<List<NumberPlan>> localVarResponse = GetSitesSiteIdNumberplansWithHttpInfo(siteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        public ApiResponse< List<NumberPlan> > GetSitesSiteIdNumberplansWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSitesSiteIdNumberplans");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<NumberPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NumberPlan>)));
            
        }

        
        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<NumberPlan>> GetSitesSiteIdNumberplansAsync (string siteId)
        {
             ApiResponse<List<NumberPlan>> localVarResponse = await GetSitesSiteIdNumberplansAsyncWithHttpInfo(siteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of Number Plans for this Site. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> GetSitesSiteIdNumberplansAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSitesSiteIdNumberplans");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<NumberPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NumberPlan>)));
            
        }
        
        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <param name="classification">Classification</param> 
        /// <returns>List&lt;string&gt;</returns>
        public List<string> GetSitesSiteIdNumberplansClassifications (string siteId, string classification = null)
        {
             ApiResponse<List<string>> localVarResponse = GetSitesSiteIdNumberplansClassificationsWithHttpInfo(siteId, classification);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <param name="classification">Classification</param> 
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse< List<string> > GetSitesSiteIdNumberplansClassificationsWithHttpInfo (string siteId, string classification = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSitesSiteIdNumberplansClassifications");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans/classifications";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            if (classification != null) localVarQueryParams.Add("classification", Configuration.ApiClient.ParameterToString(classification)); // query parameter
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplansClassifications: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplansClassifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }

        
        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> GetSitesSiteIdNumberplansClassificationsAsync (string siteId, string classification = null)
        {
             ApiResponse<List<string>> localVarResponse = await GetSitesSiteIdNumberplansClassificationsAsyncWithHttpInfo(siteId, classification);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of Classifications for this Site 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="classification">Classification</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<string>>> GetSitesSiteIdNumberplansClassificationsAsyncWithHttpInfo (string siteId, string classification = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSitesSiteIdNumberplansClassifications");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans/classifications";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            if (classification != null) localVarQueryParams.Add("classification", Configuration.ApiClient.ParameterToString(classification)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplansClassifications: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplansClassifications: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<string>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<string>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<string>)));
            
        }
        
        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <param name="numberPlanId">Number Plan ID</param> 
        /// <returns>NumberPlan</returns>
        public NumberPlan GetSitesSiteIdNumberplansNumberplanId (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> localVarResponse = GetSitesSiteIdNumberplansNumberplanIdWithHttpInfo(siteId, numberPlanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <param name="numberPlanId">Number Plan ID</param> 
        /// <returns>ApiResponse of NumberPlan</returns>
        public ApiResponse< NumberPlan > GetSitesSiteIdNumberplansNumberplanIdWithHttpInfo (string siteId, string numberPlanId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->GetSitesSiteIdNumberplansNumberplanId");
            
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null)
                throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling ConfigurationApi->GetSitesSiteIdNumberplansNumberplanId");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans/{numberPlanId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (numberPlanId != null) localVarPathParams.Add("numberPlanId", Configuration.ApiClient.ParameterToString(numberPlanId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplansNumberplanId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplansNumberplanId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<NumberPlan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NumberPlan) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NumberPlan)));
            
        }

        
        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of NumberPlan</returns>
        public async System.Threading.Tasks.Task<NumberPlan> GetSitesSiteIdNumberplansNumberplanIdAsync (string siteId, string numberPlanId)
        {
             ApiResponse<NumberPlan> localVarResponse = await GetSitesSiteIdNumberplansNumberplanIdAsyncWithHttpInfo(siteId, numberPlanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Number Plan by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="numberPlanId">Number Plan ID</param>
        /// <returns>Task of ApiResponse (NumberPlan)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NumberPlan>> GetSitesSiteIdNumberplansNumberplanIdAsyncWithHttpInfo (string siteId, string numberPlanId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling GetSitesSiteIdNumberplansNumberplanId");
            // verify the required parameter 'numberPlanId' is set
            if (numberPlanId == null) throw new ApiException(400, "Missing required parameter 'numberPlanId' when calling GetSitesSiteIdNumberplansNumberplanId");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans/{numberPlanId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            if (numberPlanId != null) localVarPathParams.Add("numberPlanId", Configuration.ApiClient.ParameterToString(numberPlanId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplansNumberplanId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSitesSiteIdNumberplansNumberplanId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<NumberPlan>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NumberPlan) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NumberPlan)));
            
        }
        
        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>Policy</returns>
        public Policy PatchRetentionpoliciesPolicyId (string policyId, Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = PatchRetentionpoliciesPolicyIdWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PatchRetentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->PatchRetentionpoliciesPolicyId");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchRetentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRetentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        
        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PatchRetentionpoliciesPolicyIdAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = await PatchRetentionpoliciesPolicyIdAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PatchRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PatchRetentionpoliciesPolicyId");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchRetentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchRetentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>DIDPool</returns>
        public DIDPool PostDidpools (DIDPool body = null)
        {
             ApiResponse<DIDPool> localVarResponse = PostDidpoolsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > PostDidpoolsWithHttpInfo (DIDPool body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/didpools";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostDidpools: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDidpools: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }

        
        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> PostDidpoolsAsync (DIDPool body = null)
        {
             ApiResponse<DIDPool> localVarResponse = await PostDidpoolsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new DID pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> PostDidpoolsAsyncWithHttpInfo (DIDPool body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/didpools";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostDidpools: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostDidpools: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }
        
        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge</param> 
        /// <returns>Edge</returns>
        public Edge PostEdges (Edge body = null)
        {
             ApiResponse<Edge> localVarResponse = PostEdgesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > PostEdgesWithHttpInfo (Edge body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/edges";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdges: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdges: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }

        
        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> PostEdgesAsync (Edge body = null)
        {
             ApiResponse<Edge> localVarResponse = await PostEdgesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> PostEdgesAsyncWithHttpInfo (Edge body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/edges";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdges: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdges: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }
        
        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority</param> 
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority PostEdgesCertificateauthorities (DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = PostEdgesCertificateauthoritiesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority</param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > PostEdgesCertificateauthoritiesWithHttpInfo (DomainCertificateAuthority body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesCertificateauthorities: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesCertificateauthorities: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }

        
        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> PostEdgesCertificateauthoritiesAsync (DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = await PostEdgesCertificateauthoritiesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CertificateAuthority</param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PostEdgesCertificateauthoritiesAsyncWithHttpInfo (DomainCertificateAuthority body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesCertificateauthorities: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesCertificateauthorities: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }
        
        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>DomainLogicalInterface</returns>
        public DomainLogicalInterface PostEdgesEdgeIdLogicalinterfaces (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = PostEdgesEdgeIdLogicalinterfacesWithHttpInfo(edgeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > PostEdgesEdgeIdLogicalinterfacesWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdLogicalinterfaces");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogicalinterfaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogicalinterfaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }

        
        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainLogicalInterface> PostEdgesEdgeIdLogicalinterfacesAsync (string edgeId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = await PostEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo(edgeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an edge logical interface. Create
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PostEdgesEdgeIdLogicalinterfacesAsyncWithHttpInfo (string edgeId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdLogicalinterfaces");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogicalinterfaces: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogicalinterfaces: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }
        
        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">EdgeLogsJobRequest</param> 
        /// <returns>EdgeLogsJobResponse</returns>
        public EdgeLogsJobResponse PostEdgesEdgeIdLogsJobs (string edgeId, EdgeLogsJobRequest body = null)
        {
             ApiResponse<EdgeLogsJobResponse> localVarResponse = PostEdgesEdgeIdLogsJobsWithHttpInfo(edgeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">EdgeLogsJobRequest</param> 
        /// <returns>ApiResponse of EdgeLogsJobResponse</returns>
        public ApiResponse< EdgeLogsJobResponse > PostEdgesEdgeIdLogsJobsWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdLogsJobs");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logs/jobs";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogsJobs: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeLogsJobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLogsJobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLogsJobResponse)));
            
        }

        
        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of EdgeLogsJobResponse</returns>
        public async System.Threading.Tasks.Task<EdgeLogsJobResponse> PostEdgesEdgeIdLogsJobsAsync (string edgeId, EdgeLogsJobRequest body = null)
        {
             ApiResponse<EdgeLogsJobResponse> localVarResponse = await PostEdgesEdgeIdLogsJobsAsyncWithHttpInfo(edgeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a job to upload a list of Edge logs. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">EdgeLogsJobRequest</param>
        /// <returns>Task of ApiResponse (EdgeLogsJobResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLogsJobResponse>> PostEdgesEdgeIdLogsJobsAsyncWithHttpInfo (string edgeId, EdgeLogsJobRequest body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdLogsJobs");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logs/jobs";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogsJobs: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogsJobs: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLogsJobResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLogsJobResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLogsJobResponse)));
            
        }
        
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId">Job ID</param> 
        /// <param name="body"></param> 
        /// <returns></returns>
        public void PostEdgesEdgeIdLogsJobsJobIdUpload (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
             PostEdgesEdgeIdLogsJobsJobIdUploadWithHttpInfo(edgeId, jobId, body);
        }

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="jobId">Job ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostEdgesEdgeIdLogsJobsJobIdUploadWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdLogsJobsJobIdUpload");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ConfigurationApi->PostEdgesEdgeIdLogsJobsJobIdUpload");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logs/jobs/{jobId}/upload";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (jobId != null) localVarPathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogsJobsJobIdUpload: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogsJobsJobIdUpload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostEdgesEdgeIdLogsJobsJobIdUploadAsync (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
             await PostEdgesEdgeIdLogsJobsJobIdUploadAsyncWithHttpInfo(edgeId, jobId, body);

        }

        /// <summary>
        /// Request that the specified fileIds be uploaded from the Edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="jobId">Job ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostEdgesEdgeIdLogsJobsJobIdUploadAsyncWithHttpInfo (string edgeId, string jobId, EdgeLogsJobUploadRequest body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdLogsJobsJobIdUpload");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling PostEdgesEdgeIdLogsJobsJobIdUpload");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logs/jobs/{jobId}/upload";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (jobId != null) localVarPathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogsJobsJobIdUpload: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdLogsJobsJobIdUpload: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>string</returns>
        public string PostEdgesEdgeIdReboot (string edgeId)
        {
             ApiResponse<string> localVarResponse = PostEdgesEdgeIdRebootWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostEdgesEdgeIdRebootWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdReboot");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/reboot";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdReboot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdReboot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostEdgesEdgeIdRebootAsync (string edgeId)
        {
             ApiResponse<string> localVarResponse = await PostEdgesEdgeIdRebootAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reboot an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostEdgesEdgeIdRebootAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdReboot");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/reboot";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdReboot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdReboot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>DomainEdgeSoftwareUpdateDto</returns>
        public DomainEdgeSoftwareUpdateDto PostEdgesEdgeIdSoftwareupdate (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> localVarResponse = PostEdgesEdgeIdSoftwareupdateWithHttpInfo(edgeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainEdgeSoftwareUpdateDto</returns>
        public ApiResponse< DomainEdgeSoftwareUpdateDto > PostEdgesEdgeIdSoftwareupdateWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdSoftwareupdate");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdSoftwareupdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdSoftwareupdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }

        
        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainEdgeSoftwareUpdateDto</returns>
        public async System.Threading.Tasks.Task<DomainEdgeSoftwareUpdateDto> PostEdgesEdgeIdSoftwareupdateAsync (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
             ApiResponse<DomainEdgeSoftwareUpdateDto> localVarResponse = await PostEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo(edgeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Starts a software update for this edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainEdgeSoftwareUpdateDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainEdgeSoftwareUpdateDto>> PostEdgesEdgeIdSoftwareupdateAsyncWithHttpInfo (string edgeId, DomainEdgeSoftwareUpdateDto body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdSoftwareupdate");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/softwareupdate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdSoftwareupdate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdSoftwareupdate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainEdgeSoftwareUpdateDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainEdgeSoftwareUpdateDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainEdgeSoftwareUpdateDto)));
            
        }
        
        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param> 
        /// <returns>string</returns>
        public string PostEdgesEdgeIdUnpair (string edgeId)
        {
             ApiResponse<string> localVarResponse = PostEdgesEdgeIdUnpairWithHttpInfo(edgeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostEdgesEdgeIdUnpairWithHttpInfo (string edgeId)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PostEdgesEdgeIdUnpair");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/unpair";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdUnpair: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdUnpair: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostEdgesEdgeIdUnpairAsync (string edgeId)
        {
             ApiResponse<string> localVarResponse = await PostEdgesEdgeIdUnpairAsyncWithHttpInfo(edgeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unpair an Edge 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge Id</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostEdgesEdgeIdUnpairAsyncWithHttpInfo (string edgeId)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PostEdgesEdgeIdUnpair");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/unpair";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdUnpair: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEdgesEdgeIdUnpair: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>Endpoint</returns>
        public Endpoint PostEndpoints (Endpoint body = null)
        {
             ApiResponse<Endpoint> localVarResponse = PostEndpointsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > PostEndpointsWithHttpInfo (Endpoint body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/endpoints";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEndpoints: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEndpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }

        
        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> PostEndpointsAsync (Endpoint body = null)
        {
             ApiResponse<Endpoint> localVarResponse = await PostEndpointsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> PostEndpointsAsyncWithHttpInfo (Endpoint body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/endpoints";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostEndpoints: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEndpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }
        
        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool</param> 
        /// <returns>Extension</returns>
        public Extension PostExtensionpools (ExtensionPool body = null)
        {
             ApiResponse<Extension> localVarResponse = PostExtensionpoolsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool</param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > PostExtensionpoolsWithHttpInfo (ExtensionPool body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/extensionpools";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExtensionpools: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExtensionpools: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }

        
        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> PostExtensionpoolsAsync (ExtensionPool body = null)
        {
             ApiResponse<Extension> localVarResponse = await PostExtensionpoolsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new extension pool 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> PostExtensionpoolsAsyncWithHttpInfo (ExtensionPool body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/extensionpools";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostExtensionpools: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostExtensionpools: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }
        
        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param> 
        /// <returns>Organization</returns>
        public Organization PostOrganizations (OrganizationCreate body = null)
        {
             ApiResponse<Organization> localVarResponse = PostOrganizationsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > PostOrganizationsWithHttpInfo (OrganizationCreate body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/organizations";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOrganizations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        
        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> PostOrganizationsAsync (OrganizationCreate body = null)
        {
             ApiResponse<Organization> localVarResponse = await PostOrganizationsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> PostOrganizationsAsyncWithHttpInfo (OrganizationCreate body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/organizations";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostOrganizations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostOrganizations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EncryptionKey</returns>
        public EncryptionKey PostRecordingkeys ()
        {
             ApiResponse<EncryptionKey> localVarResponse = PostRecordingkeysWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EncryptionKey</returns>
        public ApiResponse< EncryptionKey > PostRecordingkeysWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/recordingkeys";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)));
            
        }

        
        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EncryptionKey</returns>
        public async System.Threading.Tasks.Task<EncryptionKey> PostRecordingkeysAsync ()
        {
             ApiResponse<EncryptionKey> localVarResponse = await PostRecordingkeysAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingkeysAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/api/v1/configuration/recordingkeys";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)));
            
        }
        
        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param> 
        /// <returns>Policy</returns>
        public Policy PostRetentionpolicies (Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = PostRetentionpoliciesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PostRetentionpoliciesWithHttpInfo (Policy body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostRetentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRetentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        
        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PostRetentionpoliciesAsync (Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = await PostRetentionpoliciesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PostRetentionpoliciesAsyncWithHttpInfo (Policy body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostRetentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRetentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site</param> 
        /// <returns>Site</returns>
        public Site PostSites (Site body = null)
        {
             ApiResponse<Site> localVarResponse = PostSitesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > PostSitesWithHttpInfo (Site body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/sites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }

        
        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> PostSitesAsync (Site body = null)
        {
             ApiResponse<Site> localVarResponse = await PostSitesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> PostSitesAsyncWithHttpInfo (Site body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/sites";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSites: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSites: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }
        
        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <returns></returns>
        public void PostSitesSiteIdRebalance (string siteId)
        {
             PostSitesSiteIdRebalanceWithHttpInfo(siteId);
        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostSitesSiteIdRebalanceWithHttpInfo (string siteId)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->PostSitesSiteIdRebalance");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/rebalance";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSitesSiteIdRebalance: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSitesSiteIdRebalance: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostSitesSiteIdRebalanceAsync (string siteId)
        {
             await PostSitesSiteIdRebalanceAsyncWithHttpInfo(siteId);

        }

        /// <summary>
        /// Triggers the rebalance operation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostSitesSiteIdRebalanceAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling PostSitesSiteIdRebalance");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/rebalance";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostSitesSiteIdRebalance: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostSitesSiteIdRebalance: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <param name="body"></param> 
        /// <returns>DIDPool</returns>
        public DIDPool PutDidpoolsDidpoolId (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> localVarResponse = PutDidpoolsDidpoolIdWithHttpInfo(didPoolId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DIDPool</returns>
        public ApiResponse< DIDPool > PutDidpoolsDidpoolIdWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null)
                throw new ApiException(400, "Missing required parameter 'didPoolId' when calling ConfigurationApi->PutDidpoolsDidpoolId");
            
    
            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutDidpoolsDidpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDidpoolsDidpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }

        
        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DIDPool</returns>
        public async System.Threading.Tasks.Task<DIDPool> PutDidpoolsDidpoolIdAsync (string didPoolId, DIDPool body = null)
        {
             ApiResponse<DIDPool> localVarResponse = await PutDidpoolsDidpoolIdAsyncWithHttpInfo(didPoolId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a DID Pool by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didPoolId">DID pool ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DIDPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DIDPool>> PutDidpoolsDidpoolIdAsyncWithHttpInfo (string didPoolId, DIDPool body = null)
        {
            // verify the required parameter 'didPoolId' is set
            if (didPoolId == null) throw new ApiException(400, "Missing required parameter 'didPoolId' when calling PutDidpoolsDidpoolId");
            
    
            var localVarPath = "/api/v1/configuration/didpools/{didPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didPoolId != null) localVarPathParams.Add("didPoolId", Configuration.ApiClient.ParameterToString(didPoolId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutDidpoolsDidpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDidpoolsDidpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DIDPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DIDPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DIDPool)));
            
        }
        
        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param> 
        /// <param name="body"></param> 
        /// <returns>DID</returns>
        public DID PutDidsDidId (string didId, DID body = null)
        {
             ApiResponse<DID> localVarResponse = PutDidsDidIdWithHttpInfo(didId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DID</returns>
        public ApiResponse< DID > PutDidsDidIdWithHttpInfo (string didId, DID body = null)
        {
            
            // verify the required parameter 'didId' is set
            if (didId == null)
                throw new ApiException(400, "Missing required parameter 'didId' when calling ConfigurationApi->PutDidsDidId");
            
    
            var localVarPath = "/api/v1/configuration/dids/{didId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didId != null) localVarPathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutDidsDidId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDidsDidId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DID>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DID)));
            
        }

        
        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DID</returns>
        public async System.Threading.Tasks.Task<DID> PutDidsDidIdAsync (string didId, DID body = null)
        {
             ApiResponse<DID> localVarResponse = await PutDidsDidIdAsyncWithHttpInfo(didId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a DID by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="didId">DID ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DID)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DID>> PutDidsDidIdAsyncWithHttpInfo (string didId, DID body = null)
        {
            // verify the required parameter 'didId' is set
            if (didId == null) throw new ApiException(400, "Missing required parameter 'didId' when calling PutDidsDidId");
            
    
            var localVarPath = "/api/v1/configuration/dids/{didId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (didId != null) localVarPathParams.Add("didId", Configuration.ApiClient.ParameterToString(didId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutDidsDidId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutDidsDidId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DID>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DID) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DID)));
            
        }
        
        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param> 
        /// <param name="body"></param> 
        /// <returns>DomainCertificateAuthority</returns>
        public DomainCertificateAuthority PutEdgesCertificateauthoritiesCertificateId (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = PutEdgesCertificateauthoritiesCertificateIdWithHttpInfo(certificateId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainCertificateAuthority</returns>
        public ApiResponse< DomainCertificateAuthority > PutEdgesCertificateauthoritiesCertificateIdWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            
            // verify the required parameter 'certificateId' is set
            if (certificateId == null)
                throw new ApiException(400, "Missing required parameter 'certificateId' when calling ConfigurationApi->PutEdgesCertificateauthoritiesCertificateId");
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesCertificateauthoritiesCertificateId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesCertificateauthoritiesCertificateId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }

        
        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainCertificateAuthority</returns>
        public async System.Threading.Tasks.Task<DomainCertificateAuthority> PutEdgesCertificateauthoritiesCertificateIdAsync (string certificateId, DomainCertificateAuthority body = null)
        {
             ApiResponse<DomainCertificateAuthority> localVarResponse = await PutEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo(certificateId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a certificate authority. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certificateId">Certificate ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainCertificateAuthority)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainCertificateAuthority>> PutEdgesCertificateauthoritiesCertificateIdAsyncWithHttpInfo (string certificateId, DomainCertificateAuthority body = null)
        {
            // verify the required parameter 'certificateId' is set
            if (certificateId == null) throw new ApiException(400, "Missing required parameter 'certificateId' when calling PutEdgesCertificateauthoritiesCertificateId");
            
    
            var localVarPath = "/api/v1/configuration/edges/certificateauthorities/{certificateId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (certificateId != null) localVarPathParams.Add("certificateId", Configuration.ApiClient.ParameterToString(certificateId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesCertificateauthoritiesCertificateId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesCertificateauthoritiesCertificateId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainCertificateAuthority>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainCertificateAuthority) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainCertificateAuthority)));
            
        }
        
        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">Edge</param> 
        /// <returns>Edge</returns>
        public Edge PutEdgesEdgeId (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> localVarResponse = PutEdgesEdgeIdWithHttpInfo(edgeId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="body">Edge</param> 
        /// <returns>ApiResponse of Edge</returns>
        public ApiResponse< Edge > PutEdgesEdgeIdWithHttpInfo (string edgeId, Edge body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PutEdgesEdgeId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }

        
        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of Edge</returns>
        public async System.Threading.Tasks.Task<Edge> PutEdgesEdgeIdAsync (string edgeId, Edge body = null)
        {
             ApiResponse<Edge> localVarResponse = await PutEdgesEdgeIdAsyncWithHttpInfo(edgeId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a edge. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="body">Edge</param>
        /// <returns>Task of ApiResponse (Edge)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Edge>> PutEdgesEdgeIdAsyncWithHttpInfo (string edgeId, Edge body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PutEdgesEdgeId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Edge>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Edge) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Edge)));
            
        }
        
        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <param name="body">Line</param> 
        /// <returns>EdgeLine</returns>
        public EdgeLine PutEdgesEdgeIdLinesLineId (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> localVarResponse = PutEdgesEdgeIdLinesLineIdWithHttpInfo(edgeId, lineId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="lineId">Line ID</param> 
        /// <param name="body">Line</param> 
        /// <returns>ApiResponse of EdgeLine</returns>
        public ApiResponse< EdgeLine > PutEdgesEdgeIdLinesLineIdWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PutEdgesEdgeIdLinesLineId");
            
            // verify the required parameter 'lineId' is set
            if (lineId == null)
                throw new ApiException(400, "Missing required parameter 'lineId' when calling ConfigurationApi->PutEdgesEdgeIdLinesLineId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) localVarPathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeIdLinesLineId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeIdLinesLineId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EdgeLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLine)));
            
        }

        
        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of EdgeLine</returns>
        public async System.Threading.Tasks.Task<EdgeLine> PutEdgesEdgeIdLinesLineIdAsync (string edgeId, string lineId, EdgeLine body = null)
        {
             ApiResponse<EdgeLine> localVarResponse = await PutEdgesEdgeIdLinesLineIdAsyncWithHttpInfo(edgeId, lineId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a line. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="lineId">Line ID</param>
        /// <param name="body">Line</param>
        /// <returns>Task of ApiResponse (EdgeLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EdgeLine>> PutEdgesEdgeIdLinesLineIdAsyncWithHttpInfo (string edgeId, string lineId, EdgeLine body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PutEdgesEdgeIdLinesLineId");
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling PutEdgesEdgeIdLinesLineId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/lines/{lineId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (lineId != null) localVarPathParams.Add("lineId", Configuration.ApiClient.ParameterToString(lineId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeIdLinesLineId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeIdLinesLineId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EdgeLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EdgeLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EdgeLine)));
            
        }
        
        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <param name="body"></param> 
        /// <returns>DomainLogicalInterface</returns>
        public DomainLogicalInterface PutEdgesEdgeIdLogicalinterfacesInterfaceId (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = PutEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo(edgeId, interfaceId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param> 
        /// <param name="interfaceId">Interface ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of DomainLogicalInterface</returns>
        public ApiResponse< DomainLogicalInterface > PutEdgesEdgeIdLogicalinterfacesInterfaceIdWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            
            // verify the required parameter 'edgeId' is set
            if (edgeId == null)
                throw new ApiException(400, "Missing required parameter 'edgeId' when calling ConfigurationApi->PutEdgesEdgeIdLogicalinterfacesInterfaceId");
            
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null)
                throw new ApiException(400, "Missing required parameter 'interfaceId' when calling ConfigurationApi->PutEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }

        
        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of DomainLogicalInterface</returns>
        public async System.Threading.Tasks.Task<DomainLogicalInterface> PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsync (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
             ApiResponse<DomainLogicalInterface> localVarResponse = await PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo(edgeId, interfaceId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an edge logical interface. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeId">Edge ID</param>
        /// <param name="interfaceId">Interface ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (DomainLogicalInterface)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainLogicalInterface>> PutEdgesEdgeIdLogicalinterfacesInterfaceIdAsyncWithHttpInfo (string edgeId, string interfaceId, DomainLogicalInterface body = null)
        {
            // verify the required parameter 'edgeId' is set
            if (edgeId == null) throw new ApiException(400, "Missing required parameter 'edgeId' when calling PutEdgesEdgeIdLogicalinterfacesInterfaceId");
            // verify the required parameter 'interfaceId' is set
            if (interfaceId == null) throw new ApiException(400, "Missing required parameter 'interfaceId' when calling PutEdgesEdgeIdLogicalinterfacesInterfaceId");
            
    
            var localVarPath = "/api/v1/configuration/edges/{edgeId}/logicalinterfaces/{interfaceId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (edgeId != null) localVarPathParams.Add("edgeId", Configuration.ApiClient.ParameterToString(edgeId)); // path parameter
            if (interfaceId != null) localVarPathParams.Add("interfaceId", Configuration.ApiClient.ParameterToString(interfaceId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEdgesEdgeIdLogicalinterfacesInterfaceId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DomainLogicalInterface>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DomainLogicalInterface) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DomainLogicalInterface)));
            
        }
        
        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>Endpoint</returns>
        public Endpoint PutEndpointsEndpointId (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> localVarResponse = PutEndpointsEndpointIdWithHttpInfo(endpointId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param> 
        /// <param name="body">EndpointTemplate</param> 
        /// <returns>ApiResponse of Endpoint</returns>
        public ApiResponse< Endpoint > PutEndpointsEndpointIdWithHttpInfo (string endpointId, Endpoint body = null)
        {
            
            // verify the required parameter 'endpointId' is set
            if (endpointId == null)
                throw new ApiException(400, "Missing required parameter 'endpointId' when calling ConfigurationApi->PutEndpointsEndpointId");
            
    
            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEndpointsEndpointId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEndpointsEndpointId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }

        
        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of Endpoint</returns>
        public async System.Threading.Tasks.Task<Endpoint> PutEndpointsEndpointIdAsync (string endpointId, Endpoint body = null)
        {
             ApiResponse<Endpoint> localVarResponse = await PutEndpointsEndpointIdAsyncWithHttpInfo(endpointId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update endpoint 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endpointId">Endpoint ID</param>
        /// <param name="body">EndpointTemplate</param>
        /// <returns>Task of ApiResponse (Endpoint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endpoint>> PutEndpointsEndpointIdAsyncWithHttpInfo (string endpointId, Endpoint body = null)
        {
            // verify the required parameter 'endpointId' is set
            if (endpointId == null) throw new ApiException(400, "Missing required parameter 'endpointId' when calling PutEndpointsEndpointId");
            
    
            var localVarPath = "/api/v1/configuration/endpoints/{endpointId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (endpointId != null) localVarPathParams.Add("endpointId", Configuration.ApiClient.ParameterToString(endpointId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutEndpointsEndpointId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutEndpointsEndpointId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endpoint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endpoint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endpoint)));
            
        }
        
        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <param name="body">ExtensionPool</param> 
        /// <returns>ExtensionPool</returns>
        public ExtensionPool PutExtensionpoolsExtensionpoolId (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> localVarResponse = PutExtensionpoolsExtensionpoolIdWithHttpInfo(extensionPoolId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param> 
        /// <param name="body">ExtensionPool</param> 
        /// <returns>ApiResponse of ExtensionPool</returns>
        public ApiResponse< ExtensionPool > PutExtensionpoolsExtensionpoolIdWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null)
                throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling ConfigurationApi->PutExtensionpoolsExtensionpoolId");
            
    
            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExtensionpoolsExtensionpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExtensionpoolsExtensionpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExtensionPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPool)));
            
        }

        
        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ExtensionPool</returns>
        public async System.Threading.Tasks.Task<ExtensionPool> PutExtensionpoolsExtensionpoolIdAsync (string extensionPoolId, ExtensionPool body = null)
        {
             ApiResponse<ExtensionPool> localVarResponse = await PutExtensionpoolsExtensionpoolIdAsyncWithHttpInfo(extensionPoolId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an extension pool by ID 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionPoolId">Extension pool ID</param>
        /// <param name="body">ExtensionPool</param>
        /// <returns>Task of ApiResponse (ExtensionPool)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionPool>> PutExtensionpoolsExtensionpoolIdAsyncWithHttpInfo (string extensionPoolId, ExtensionPool body = null)
        {
            // verify the required parameter 'extensionPoolId' is set
            if (extensionPoolId == null) throw new ApiException(400, "Missing required parameter 'extensionPoolId' when calling PutExtensionpoolsExtensionpoolId");
            
    
            var localVarPath = "/api/v1/configuration/extensionpools/{extensionPoolId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionPoolId != null) localVarPathParams.Add("extensionPoolId", Configuration.ApiClient.ParameterToString(extensionPoolId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExtensionpoolsExtensionpoolId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExtensionpoolsExtensionpoolId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionPool>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionPool) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionPool)));
            
        }
        
        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param> 
        /// <param name="body"></param> 
        /// <returns>Extension</returns>
        public Extension PutExtensionsExtensionId (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> localVarResponse = PutExtensionsExtensionIdWithHttpInfo(extensionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of Extension</returns>
        public ApiResponse< Extension > PutExtensionsExtensionIdWithHttpInfo (string extensionId, Extension body = null)
        {
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling ConfigurationApi->PutExtensionsExtensionId");
            
    
            var localVarPath = "/api/v1/configuration/extensions/{extensionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExtensionsExtensionId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExtensionsExtensionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }

        
        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of Extension</returns>
        public async System.Threading.Tasks.Task<Extension> PutExtensionsExtensionIdAsync (string extensionId, Extension body = null)
        {
             ApiResponse<Extension> localVarResponse = await PutExtensionsExtensionIdAsyncWithHttpInfo(extensionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an extension by ID. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="extensionId">Extension ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Extension)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Extension>> PutExtensionsExtensionIdAsyncWithHttpInfo (string extensionId, Extension body = null)
        {
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling PutExtensionsExtensionId");
            
    
            var localVarPath = "/api/v1/configuration/extensions/{extensionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutExtensionsExtensionId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutExtensionsExtensionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Extension>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Extension) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Extension)));
            
        }
        
        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param> 
        /// <returns>Organization</returns>
        public Organization PutOrganization (Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = PutOrganizationWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > PutOrganizationWithHttpInfo (Organization body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/organization";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        
        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> PutOrganizationAsync (Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = await PutOrganizationAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update context organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationAsyncWithHttpInfo (Organization body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/organization";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganization: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganization: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param> 
        /// <param name="body">Organization</param> 
        /// <returns>Organization</returns>
        public Organization PutOrganizationsOrgId (string orgId, Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = PutOrganizationsOrgIdWithHttpInfo(orgId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param> 
        /// <param name="body">Organization</param> 
        /// <returns>ApiResponse of Organization</returns>
        public ApiResponse< Organization > PutOrganizationsOrgIdWithHttpInfo (string orgId, Organization body = null)
        {
            
            // verify the required parameter 'orgId' is set
            if (orgId == null)
                throw new ApiException(400, "Missing required parameter 'orgId' when calling ConfigurationApi->PutOrganizationsOrgId");
            
    
            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsOrgId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }

        
        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> PutOrganizationsOrgIdAsync (string orgId, Organization body = null)
        {
             ApiResponse<Organization> localVarResponse = await PutOrganizationsOrgIdAsyncWithHttpInfo(orgId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update organization. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orgId">Organization ID</param>
        /// <param name="body">Organization</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Organization>> PutOrganizationsOrgIdAsyncWithHttpInfo (string orgId, Organization body = null)
        {
            // verify the required parameter 'orgId' is set
            if (orgId == null) throw new ApiException(400, "Missing required parameter 'orgId' when calling PutOrganizationsOrgId");
            
    
            var localVarPath = "/api/v1/configuration/organizations/{orgId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (orgId != null) localVarPathParams.Add("orgId", Configuration.ApiClient.ParameterToString(orgId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsOrgId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrganizationsOrgId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Organization>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Organization) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Organization)));
            
        }
        
        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param> 
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule PutRecordingkeysRotationschedule (KeyRotationSchedule body = null)
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = PutRecordingkeysRotationscheduleWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param> 
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > PutRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/recordingkeys/rotationschedule";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        
        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> PutRecordingkeysRotationscheduleAsync (KeyRotationSchedule body = null)
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = await PutRecordingkeysRotationscheduleAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> PutRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body = null)
        {
            
    
            var localVarPath = "/api/v1/configuration/recordingkeys/rotationschedule";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }
        
        /// <summary>
        /// Update policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>Policy</returns>
        public Policy PutRetentionpoliciesPolicyId (string policyId, Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = PutRetentionpoliciesPolicyIdWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param> 
        /// <param name="body">Policy</param> 
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PutRetentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body = null)
        {
            
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling ConfigurationApi->PutRetentionpoliciesPolicyId");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutRetentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRetentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        
        /// <summary>
        /// Update policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PutRetentionpoliciesPolicyIdAsync (string policyId, Policy body = null)
        {
             ApiResponse<Policy> localVarResponse = await PutRetentionpoliciesPolicyIdAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PutRetentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body = null)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling PutRetentionpoliciesPolicyId");
            
    
            var localVarPath = "/api/v1/configuration/retentionpolicies/{policyId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutRetentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRetentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }
        
        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body">Site</param> 
        /// <returns>Site</returns>
        public Site PutSitesSiteId (string siteId, Site body = null)
        {
             ApiResponse<Site> localVarResponse = PutSitesSiteIdWithHttpInfo(siteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body">Site</param> 
        /// <returns>ApiResponse of Site</returns>
        public ApiResponse< Site > PutSitesSiteIdWithHttpInfo (string siteId, Site body = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->PutSitesSiteId");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSitesSiteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSitesSiteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }

        
        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of Site</returns>
        public async System.Threading.Tasks.Task<Site> PutSitesSiteIdAsync (string siteId, Site body = null)
        {
             ApiResponse<Site> localVarResponse = await PutSitesSiteIdAsyncWithHttpInfo(siteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a endpoint. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body">Site</param>
        /// <returns>Task of ApiResponse (Site)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Site>> PutSitesSiteIdAsyncWithHttpInfo (string siteId, Site body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling PutSitesSiteId");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSitesSiteId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSitesSiteId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Site>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Site) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Site)));
            
        }
        
        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body"></param> 
        /// <returns>List&lt;NumberPlan&gt;</returns>
        public List<NumberPlan> PutSitesSiteIdNumberplans (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> localVarResponse = PutSitesSiteIdNumberplansWithHttpInfo(siteId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param> 
        /// <param name="body"></param> 
        /// <returns>ApiResponse of List&lt;NumberPlan&gt;</returns>
        public ApiResponse< List<NumberPlan> > PutSitesSiteIdNumberplansWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new ApiException(400, "Missing required parameter 'siteId' when calling ConfigurationApi->PutSitesSiteIdNumberplans");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSitesSiteIdNumberplans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSitesSiteIdNumberplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<NumberPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NumberPlan>)));
            
        }

        
        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of List&lt;NumberPlan&gt;</returns>
        public async System.Threading.Tasks.Task<List<NumberPlan>> PutSitesSiteIdNumberplansAsync (string siteId, List<NumberPlan> body = null)
        {
             ApiResponse<List<NumberPlan>> localVarResponse = await PutSitesSiteIdNumberplansAsyncWithHttpInfo(siteId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the list of Number Plans. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId">Site ID</param>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (List&lt;NumberPlan&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<NumberPlan>>> PutSitesSiteIdNumberplansAsyncWithHttpInfo (string siteId, List<NumberPlan> body = null)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null) throw new ApiException(400, "Missing required parameter 'siteId' when calling PutSitesSiteIdNumberplans");
            
    
            var localVarPath = "/api/v1/configuration/sites/{siteId}/numberplans";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (siteId != null) localVarPathParams.Add("siteId", Configuration.ApiClient.ParameterToString(siteId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutSitesSiteIdNumberplans: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSitesSiteIdNumberplans: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<NumberPlan>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<NumberPlan>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<NumberPlan>)));
            
        }
        
    }
    
}
